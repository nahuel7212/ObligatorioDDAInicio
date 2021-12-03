using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistance
{
    public class Repositories
    {
        private UbicacionRepository _ubicacionRepository;

        public Repositories()
        {
            this._ubicacionRepository = new UbicacionRepository();
        }

        public UbicacionRepository GetUbicacionRepository()
        {
            return this._ubicacionRepository;
        }
    }
}
