using System.Configuration;

namespace Boutique.Logica
{
    class conexion
    {
        public static string CN() {
            return @"Data Source=DELL-PC\MSSQLEXPRESS;Initial Catalog=boutique_bd;Integrated Security=True";
        }
    }
}
