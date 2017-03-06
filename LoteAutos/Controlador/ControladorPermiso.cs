using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    public class ControladorPermiso
    {   
        /// <summary>
        /// Funcion que permite traer todos los datos de la tabla permisos
        /// </summary>
        /// <returns></returns>
        public static List<permisos> getAllPermisos()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.permisos.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que permite buscar datos de la tabla permisos mediante caracteres
        /// </summary>
        /// <param name="Letra">variable tipo string</param>
        /// <returns></returns>
        public static List<permisos> Buscar(string Letra, Boolean Status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.permisos.Where(r => r.sModulo.Contains(Letra) && r.bStatusl == Status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que permite guardar y modificar datos en la tabla de permisos
        /// </summary>
        /// <param name="nPermiso">variable tipo Permiso</param>
        public void Guardar(permisos nPermiso)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nPermiso.pkPermiso > 0)
                    {
                        ctx.permisos.Attach(nPermiso);
                        ctx.Entry(nPermiso).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nPermiso).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para modificar un registro en la tabla de permisos
        /// </summary>
        /// <param name="nPermisos">variable de tipo permisos</param>
        public void Modificar(permisos nPermisos)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.permisos.Attach(nPermisos);
                    ctx.Entry(nPermisos).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para eliminar un registro en la tabla de permisos
        /// </summary>
        /// <param name="pkPermiso">variable de tipo entera</param>
        public void Eliminar(int pkPermiso)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    permisos nPermiso = ctx.permisos.Single(r => r.pkPermiso == pkPermiso);
                    ctx.Entry(nPermiso).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que te permite buscar un permiso por su primary key
        /// </summary>
        /// <param name="pkPermiso">variable de tipo entera</param>
        /// <returns></returns>
        public static permisos getPermisoById(int pkPermiso)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.permisos.Where(r => r.pkPermiso == pkPermiso).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
