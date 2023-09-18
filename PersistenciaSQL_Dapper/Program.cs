// See https://aka.ms/new-console-template for more information
//Lo primero que hacemos es descargar el nugget de Dapper y el de sqlClient

using Dapper;
using Microsoft.Data.SqlClient;
using PersistenciaSQL_Dapper;
using System.Data;

using (SqlConnection sql = new SqlConnection("Data Source=SWO5CD208FXVW\\SQLEXPRESS;Initial Catalog=WebApiNet6;Integrated Security=true;Connect Timeout=30;Encrypt=False"))
{
    //PROCEDIMIENTO ALMACENADO INSERTAR
    //Prueba prueba = new Prueba();
    //prueba.Nombre = "XXXXXX";
    //var param = new DynamicParameters();
    //param.Add("@Nombre", prueba.Nombre);
    //sql.ExecuteScalar("EjemploInsert", param, commandType: CommandType.StoredProcedure);

    //PRODEDIMIENTO ALMACENADO SIN PARAMETROS
    var r = sql.ExecuteReader("Ejemplo", commandType: CommandType.StoredProcedure);
    while (r.Read())
    {
        Console.WriteLine(r["Nombre"]);
    }

    r.Close();

    Console.WriteLine("------------------");

    //PRODEDIMIENTO ALMACENADO CON PARAMETROS
    var parametro = new DynamicParameters();
    parametro.Add("@id", 1);
    r = sql.ExecuteReader("Ejemplo", parametro, commandType: CommandType.StoredProcedure);

    while (r.Read())
    {
        Console.WriteLine(r["Nombre"]);
    }
    r.Close();

    ////INSERTAR DATOS
    //Prueba prueba = new Prueba();
    //prueba.Nombre = "Antonio";
    //string insertar = "INSERT INTO dbo.Prueba(Nombre) values (@Nombre)";
    //var res = sql.Execute(insertar, prueba);

    ////ACTUALIZAR
    //prueba.Nombre = "Antonio3";
    //string actualizar = "UPDATE dbo.Prueba SET Nombre=@Nombre where Nombre = 'Antonio'";
    //res = sql.Execute(actualizar, prueba);

    ////BORRAR
    //prueba.Nombre = "Antonio3";
    //string borrar = "DELETE FROM dbo.Prueba where Nombre = @Nombre";
    //res = sql.Execute(borrar, prueba);

    ////LISTAR DATOS
    //var consulta = "SELECT * FROM PRUEBA";
    //var lista = sql.Query<Prueba>(consulta);

    //foreach (var item in lista)
    //{
    //    Console.WriteLine(item.Id + "  " + item.Nombre);
    //}


}
