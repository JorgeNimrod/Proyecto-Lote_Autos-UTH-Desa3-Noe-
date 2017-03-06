using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    class ControladorPropietarioAutomovil
    {
        public void Guardar(propietarioautomoviles nPropietarioAutomoviles)
        {
            try
            {
                using (var ctx = new DataModel())
                {

                    ctx.Entry(nPropietarioAutomoviles).State = EntityState.Added;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que te permite buscar un propietarioautomoviles por su primary key
        /// </summary>
        /// <param name="pkPropietarioAutomoviles">variable de tipo entera</param>
        /// <returns></returns>
        public static propietarioautomoviles getUruariosById(int pkPropietarioAutomoviles)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarioautomoviles.Where(r => r.pkPropietarioAutomovil == pkPropietarioAutomoviles).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para modificar un registro en la tabla de usuarios
        /// </summary>
        /// <param name="nAutomovil">variable de tipo usuarios</param>
        public void Modificar(propietarioautomoviles nPropietarioAutomoviles)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.propietarioautomoviles.Attach(nPropietarioAutomoviles);
                    ctx.Entry(nPropietarioAutomoviles).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para eliminar un registro en la tabla de usuarios
        /// </summary>
        /// <param name="pkPropietarioAutomoviles">variable de tipo entera</param>
        public void Eliminar(int pkPropietarioAutomoviles)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    propietarioautomoviles nPropietarioAutomoviles = ctx.propietarioautomoviles.Single(r => r.pkPropietarioAutomovil == pkPropietarioAutomoviles);
                    ctx.Entry(nPropietarioAutomoviles).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<propietarioautomoviles> LastaAutomoviles(int pkPropietario, Boolean Status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarioautomoviles.Include("automoviles").Include("propietarios").Where(r => r.propietarios.pkPropietario == pkPropietario && r.bStatus == Status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
