using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos.Modelo;

namespace LoteAutos.Controlador
{
    public class ManejoSesion
    {
        public static SessiononHelper Login(string User, string Password)
        {
            SessiononHelper objSession = new SessiononHelper();
            try
            {
                using (var ctx = new DataModel())
                {
                    usuarios user = ctx.usuarios.Include("roles").Include("roles.permisosnegadosrol").
                        Where(r => r.sUsuario == User && r.bStatus == true).FirstOrDefault();
                    
                    if (user != null)
                    {
                        if (user.sPassword == Password)
                        {
                            objSession.isValid = true;
                            objSession.usuario = user;
                        }

                    }
                }
                return objSession;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public class SessiononHelper
        {
            public Boolean isValid { get; set; }
            public usuarios usuario { get; set; }
            public string msgError { get; set; }

            public Boolean tienepermiso(int validarpermiso)
            {
                Boolean tiene = false;
                if (isValid)
                {
                    try
                    {
                        using (var ctx = new DataModel())
                        {
                            permisosnegadosrol pNegado = usuario.roles.permisosnegadosrol.Where(r => r.fkPermiso == validarpermiso).FirstOrDefault();
                            if (pNegado == null) tiene = true;
                        }
                        return tiene;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    return tiene;
                }
            }

            public SessiononHelper()
            {
                this.isValid = false;
                this.usuario = null;
                this.msgError = "Datos incorrectos favor de intentar de nuevo";
            }
        }

    }

    public enum enumPermisosActivos
    {
        USUARIO = 1,
        ROL = 2,
        PERMISOS = 3,
        PERMISOSNEGADOSROL = 4,
        //----------------
        VENTAS = 5,
        PROPIETARIO = 6,
        AUTOMOVIL = 7,
        COMPRADOR = 8
    }
}
