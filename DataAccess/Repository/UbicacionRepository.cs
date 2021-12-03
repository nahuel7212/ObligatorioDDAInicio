using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UbicacionRepository
    {
        public bool ExisteNumeroTracking(long numeroTracking)
        {
            using (DAKObligatorioEntities context = new DAKObligatorioEntities())
            {
                return context.T_Envio.AsNoTracking().Any(a => a.NroTracking == numeroTracking);
            }
        }
    }
}
