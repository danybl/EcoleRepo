using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace EcoleLocale.dao
{
    class GenericRepository<TEntity> where TEntity : class
    {
        internal DbModele context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(DbModele context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if(orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Ajouter(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual Supprimer(object id){
            TEntity entiteASupprimer = dbSet.Find(id);
            Supprimer(entiteASupprimer);
        }

        public virtual void Supprimer(TEntity entiteASupprimer){
            if(context.Entry(entiteASupprimer).State == EntityState.Detached){
                dbSet.Attach(entiteASupprimer);
            }
            dbSet.Remove(entiteASupprimer);
        }

        public virtual void mettreAJour(TEntity entiteAMettreAjour){
            dbSet.Attach(entiteAMettreAjour);
            context.Entry(entiteAMettreAjour).State = EntityState.Modified;
        }
    }
}
