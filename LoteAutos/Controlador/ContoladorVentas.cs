using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    public class ContoladorVentas
    {
        /// <summary>
        /// Funsion que permite guardar nuevos registros en la tabla ventas
        /// </summary>
        /// <param name="nventas">variable de tipo venta</param>
        public void Guardar(ventas nventas)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(nventas).State = EntityState.Added;
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
