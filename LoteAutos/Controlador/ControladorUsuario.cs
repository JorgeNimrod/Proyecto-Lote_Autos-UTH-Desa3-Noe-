using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    public class ControladorUsuario
    {
        /// <summary>
        /// Funcion que te permite buscar usuarios mediante caracteres 
        /// </summary>
        /// <param name="Letra">variable de tipo string</param>
        /// <param name="Status">variable de tipo boolean</param>
        /// <returns></returns>
        public static List<usuarios> Buscar(string Letra, Boolean Status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.sUsuario.Contains(Letra) && r.bStatus == Status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para guardar datos en la tabla de usuarios
        /// </summary>
        /// <param name="nUsuario">variable de tipo usuarios</param>
        public void Guardar(usuarios nUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    
                    ctx.Entry(nUsuario).State = EntityState.Added;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que te permite buscar un usuario por su primary key
        /// </summary>
        /// <param name="pkUsuario">variable de tipo entera</param>
        /// <returns></returns>
        public static usuarios getUruariosById(int pkUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.pkUsuario == pkUsuario).FirstOrDefault();
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
        /// <param name="nUsuario">variable de tipo usuarios</param>
        public void Modificar(usuarios nUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.usuarios.Attach(nUsuario);
                    ctx.Entry(nUsuario).State = EntityState.Modified;
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
        /// <param name="pkUsuario">variable de tipo entera</param>
        public void Eliminar(int pkUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    usuarios user = ctx.usuarios.Single(r => r.pkUsuario == pkUsuario);
                    ctx.Entry(user).State = EntityState.Deleted;
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
