using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    class ControladorComisionRegistro
    {
        public void Guardar(comisionregistros nComisionRegistro)
        {
            try
            {
                using (var ctx=new DataModel())
                {
                    ctx.Entry(nComisionRegistro).State = EntityState.Added;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
