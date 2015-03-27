using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleLocale.dao.interfaces
{
    interface ICoursRepository : IDisposable
    {
        IEnumerable<cours> getCours();
        cours getCoursById(int idCours);
        void ajouterCours(cours coursAjoute);
        void supprimerCours(int coursId);
        void mettreAjourCours(cours cours);
        void save();
    }
}
