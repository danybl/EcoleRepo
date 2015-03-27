using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleLocale.dao
{
    class UnitOfWork : IDisposable
    {
        private DbModele context = new DbModele();
        private GenericRepository<cours> coursRepository;
        private GenericRepository<etudiant> etudiantRepository;
        private GenericRepository<inscriptioncours> inscriptionCoursRepository;
        private GenericRepository<professeur> professeurReposiroty;
        private GenericRepository<disponibilite> disponibiliteRepository;

        public GenericRepository<cours> CoursRepository
        {
            get
            {
                if (this.coursRepository == null)
                {
                    this.coursRepository = new GenericRepository<cours>(context);
                }
                return coursRepository;
            }
        }

        public GenericRepository<disponibilite> DisponibiliteRepository
        {
            get
            {
                if (this.disponibiliteRepository == null)
                {
                    this.disponibiliteRepository = new GenericRepository<disponibilite>(context);
                }
                return disponibiliteRepository;
            }
        }

        public GenericRepository<etudiant> EtudianRepository
        {
            get
            {
                if (this.etudiantRepository == null)
                {
                    this.etudiantRepository = new GenericRepository<etudiant>(context);
                }
                return etudiantRepository;
            }
        }

        public GenericRepository<inscriptioncours> InscriptionCoursRepository
        {
            get
            {
                if (this.inscriptionCoursRepository == null)
                {
                    this.inscriptionCoursRepository = new GenericRepository<inscriptioncours>(context);
                }
                return inscriptionCoursRepository;
            }
        }

        public GenericRepository<professeur> ProfesseurRepository
        {
            get
            {
                if (this.professeurReposiroty == null)
                {
                    this.professeurReposiroty = new GenericRepository<professeur>(context);
                }
                return professeurReposiroty;
            }
        }

        public void Save()
        {
            context.SaveChanges();
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
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
