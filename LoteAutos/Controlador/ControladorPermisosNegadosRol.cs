using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    public class ControladorPermisosNegadosRol
    {
        /// <summary>
        /// Funcion que permite guardar y modificar datos en la tabla de permisosnegadosrol
        /// </summary>
        /// <param name="nPermisosNegadosRol">variable de tipo PermisosNegadosRol</param>
        public void Guardar(permisosnegadosrol nPermisosNegadosRol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(nPermisosNegadosRol).State = EntityState.Added;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que obtiene todos los datos en la tabla de permisos
        /// </summary>
        /// <returns></returns>
        public static List<permisosnegadosrol> getAllPermisosNegadosRol()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.permisosnegadosrol.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que te permite buscar un npermisosnegadosrol por su primary key
        /// </summary>
        /// <param name="pkPermisoNegadoRol">variable de tipo entera</param>
        /// <returns></returns>
        public static permisosnegadosrol getPermisoNegadoRolById(int pkPermisoNegadoRol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.permisosnegadosrol.Where(r => r.pkPermisoNegadoRol == pkPermisoNegadoRol).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para modificar un registro en la tabla de permisosnegadosrol
        /// </summary>
        /// <param name="nPermisoNegadoRol">variable de tipo permisosnegadosrol</param>
        public void Modificar(permisosnegadosrol nPermisoNegadoRol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.permisosnegadosrol.Attach(nPermisoNegadoRol);
                    ctx.Entry(nPermisoNegadoRol).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para eliminar un registro en la tabla de permisosnegadosrol
        /// </summary>
        /// <param name="pkPermisoNegadoRol">variable de tipo entera</param>
        public void Eliminar(int pkPermisoNegadoRol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    permisosnegadosrol npermisosnegadosrol = ctx.permisosnegadosrol.Single(r => r.pkPermisoNegadoRol == pkPermisoNegadoRol);
                    ctx.Entry(npermisosnegadosrol).State = EntityState.Deleted;
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
