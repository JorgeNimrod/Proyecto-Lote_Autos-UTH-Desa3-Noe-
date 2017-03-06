using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    public class ControladorRol
    {
        public static List<roles> getAllRol(Boolean Status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.Where(r => r.bStatus == Status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<roles> Buscar(string Letra, Boolean Status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.Where(r => r.sNombre.Contains(Letra) && r.bStatus == Status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(roles nRol)
        {
            using (var ctx = new DataModel())
            {
                try
                {
                    ctx.Entry(nRol).State = EntityState.Added;
                    ctx.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static roles getRolById(int pkRol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.Where(r => r.pkRol == pkRol).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para modificar un registro en la tabla de roles
        /// </summary>
        /// <param name="nRoles">variable de tipo roles</param>
        public void Modificar(roles nRoles)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.roles.Attach(nRoles);
                    ctx.Entry(nRoles).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para eliminar un registro en la tabla de roles
        /// </summary>
        /// <param name="pkRol">variable de tipo entera</param>
        public void Eliminar(int pkRol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    roles nRoles = ctx.roles.Single(r => r.pkRol == pkRol);
                    ctx.Entry(nRoles).State = EntityState.Deleted;
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
