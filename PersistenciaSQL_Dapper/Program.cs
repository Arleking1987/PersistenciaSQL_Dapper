// See https://aka.ms/new-console-template for more information
//Lo primero que hacemos es descargar el nugget de Dapper y el de sqlClient

using Dapper;
using Microsoft.Data.SqlClient;
using PersistenciaSQL_Dapper;

using (SqlConnection sql = new SqlConnection("Data Source=;Initial Catalog=WebApiNet6;Integrated Security=true;Connect Timeout=30;Encrypt=False"))
{
    var consulta = "SELECT * FROM PRUEBA";
    var lista = sql.Query<Prueba>(consulta);

    foreach (var item in lista)
    {
        Console.WriteLine(item.Id + "  " + item.Nombre);
    }
}
