using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//importamos
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AccesoDatos
{
    //indicamos que esta clase hereda de la clase conexion
    public class AccesoDatosUsuario: ConnectionToSql
    {
        //metodo que permite el login del usuario
        public Boolean Login(string user, string pass)
        {
            //declaramos una variable implicita que será igual a la instancia sql
            //connection del metodo obtener conexion e la clase basica conexion
            using (var connection = GetConnection()) {
                //como estamos usando using no necesitamos cerrar la conexion esto debido a que este
                //objeto existirá solo hasta que terminen de ejecutarse las lineas del bloque using
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //especificamos el tipo de consulta
                    command.CommandType = CommandType.Text;
                    //agregamos los parametros de la consulta
                    command.Parameters.AddWithValue("@user",user);
                    command.Parameters.AddWithValue("@pass",pass);
                    //realizamos la consulta
                    command.CommandText = "Select * from TABLA where ATRIBUSU=@user and ATRIBPASS=@pass";
                    //copiamos los datos en un lector
                    SqlDataReader reader = command.ExecuteReader();
                    //verificamos si tiene filas
                    if (reader.HasRows)
                    {
                        //si tiene existe un usuario con esa contraseña y efectivamente
                        //puede iniciar sesion
                        return true;
                    }
                    else
                    {
                        //si no tiene el usuario y/o contraseña son incorrectos
                        return false;
                    }
                }
           
            }
        }
    }
}
