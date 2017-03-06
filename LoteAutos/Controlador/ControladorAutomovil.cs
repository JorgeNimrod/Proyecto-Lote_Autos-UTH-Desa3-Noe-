using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;
using System.Data.Entity;

namespace LoteAutos.Controlador
{
    public class ControladorAutomovil
    {
        /// <summary>
        /// Funcion que se utiliza para guardar datos en la tabla de automovil
        /// </summary>
        /// <param name="nAutomovil">variable de tipo automovil</param>
        public void Guardar(automoviles nAutomovil)
        {
            try
            {
                using (var ctx = new DataModel())
                {

                    ctx.Entry(nAutomovil).State = EntityState.Added;
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
        /// <param name="pkAutomovil">variable de tipo entera</param>
        /// <returns></returns>
        public static automoviles getautomovilById(int pkAutomovil)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.automoviles.Where(r => r.pkAutomovil == pkAutomovil).FirstOrDefault();
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
        /// <param name="pkAutomovil">variable de tipo entera</param>
        /// <returns></returns>
        public static automoviles getAutomovil(string noserie)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.automoviles.Single(r => r.sNoSerie == noserie);
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
        public void Modificar(automoviles nAutomovil)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.automoviles.Attach(nAutomovil);
                    ctx.Entry(nAutomovil).State = EntityState.Modified;
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
        /// <param name="pkAutomovil">variable de tipo entera</param>
        public void Eliminar(int pkAutomovil)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    automoviles nAutomovil = ctx.automoviles.Single(r => r.pkAutomovil == pkAutomovil);
                    ctx.Entry(nAutomovil).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<automoviles> Buscar(string letra, Boolean Status)
        {
            try
            {
                using (var ctx =  new DataModel())
                {
                    return ctx.automoviles.Where(r =>r.sNoSerie.Contains(letra) && r.bStatus == Status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
