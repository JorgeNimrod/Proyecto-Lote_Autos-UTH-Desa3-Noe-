using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    public class ControladorDetalleVentas
    {
        public void Guardar(detalleventas ndetalleventas)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(ndetalleventas).State = EntityState.Added;
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
