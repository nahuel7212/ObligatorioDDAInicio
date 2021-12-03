using DataAccess.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Ubicacion
{
    public class LUbicacionController
    {
        private Repositories repositories;

        public LUbicacionController()
        {
            repositories = new Repositories();
        }

        public string ExisteTracking(long numeroTracking)
        {
            if (!repositories.GetUbicacionRepository().ExisteNumeroTracking(numeroTracking))
                return "Numero de tracking no encontrado";

            return "";
        }

    }
}
