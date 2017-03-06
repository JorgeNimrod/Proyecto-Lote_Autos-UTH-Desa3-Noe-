using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using LoteAutos.Modelo;

namespace LoteAutos.Controlador
{
    public class ControladorPropietario
    {
        /// <summary>
        /// Funcion que te permite buscar propietarios mediante caracteres 
        /// </summary>
        /// <param name="Letra">variable tipo string</param>
        /// <param name="Status">variable tipo boleana</param>
        /// <returns></returns>
        public static List<propietarios> Buscar(string Letra, Boolean Status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.sNombre.Contains(Letra) && r.bStatus == Status).ToList();
                }
            }
            catch (Exception)
            {


                throw;
            }
        }
        /// <summary>
        /// Funcion que se utiliza para guardar datos en la tabla de propietarios
        /// </summary>
        /// <param name="nPropietarios">variable de tipo propietarios</param>
        public void Guardar(propietarios nPropietarios)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(nPropietarios).State = EntityState.Added;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que te permite buscar un propietarios por su primary key
        /// </summary>
        /// <param name="pkPropietario">variable de tipo entera</param>
        /// <returns></returns>
        public static propietarios getUruariosById(int pkPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.pkPropietario == pkPropietario).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para modificar un registro en la tabla de propietarios
        /// </summary>
        /// <param name="nPropietarios">variable de tipo propietarios</param>
        public void Modificar(propietarios nPropietarios)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.propietarios.Attach(nPropietarios);
                    ctx.Entry(nPropietarios).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que se utiliza para eliminar un registro en la tabla de propietarios
        /// </summary>
        /// <param name="pkPropietario">variable de tipo entera</param>
        public void Eliminar(int pkPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    propietarios nPropietario = ctx.propietarios.Single(r => r.pkPropietario == pkPropietario);
                    ctx.Entry(nPropietario).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Funcion que te permite buscar propietarios activos
        /// </summary>
        /// <param name="Status">variable de tipo boolean</param>
        /// <returns></returns>
        public static List<propietarios> getAllPropietarios(Boolean Status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.bStatus == Status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
