using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EcoleLocale.dao.implementations
{
    class CoursRepository : interfaces.ICoursRepository, IDisposable
    {
        private DbModele context;

        public CoursRepository(DbModele context)
        {
            this.context = context;
        }

        public IEnumerable<cours> getCours()
        {
            return context.cours.ToList();

            throw new NotImplementedException();
        }

        public cours getCoursById(int idCours)
        {
            return context.cours.Find(idCours);

            throw new NotImplementedException();
        }

        public void ajouterCours(cours coursAjoute)
        {
            context.cours.Add(coursAjoute);

            throw new NotImplementedException();
        }

        public void supprimerCours(int coursId)
        {
            cours cours = context.cours.Find(coursId);
            context.cours.Remove(cours);

            throw new NotImplementedException();
        }

        public void mettreAjourCours(cours cours)
        {
            context.Entry(cours).State = EntityState.Modified;

            throw new NotImplementedException();
        }

        public void save()
        {
            context.SaveChanges();

            throw new NotImplementedException();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;

            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
