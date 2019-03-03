using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referenciamos a la libreria data sql
using System.Data.SqlClient;
namespace AccesoDatos
{
    //que sea abstracta quiere decir que no se puede instanciar
    //solo se puede usar como una clase base
    //privada para que pueda ser modificada solo por la misma clase
    //solo lectura, el valor solo puede ser accedido por el constructor
    public abstract class ConnectionToSql
    {
        //para la cadena de conexion
        private readonly string connectionstring;
        //creamos el constructor
        public ConnectionToSql()
        {
            //connectionstring - "";

        }
        //creamos el metodo para obtener la conexion
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);

        }
    }
}
