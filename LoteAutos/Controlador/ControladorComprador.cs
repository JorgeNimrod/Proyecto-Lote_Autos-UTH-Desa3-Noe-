using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    public class ControladorComprador
    {
        /// <summary>
        /// funcion que permite guardar nuevos registros en la tabla de compradores
        /// </summary>
        /// <param name="ncompradores">variable de tipo compradores</param>
        public void Guardar(compradores ncompradores)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(ncompradores).State = EntityState.Added;
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
