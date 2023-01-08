using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace band_name_repository;

public abstract class BaseRepository: IDisposable
{
  private readonly IConfiguration _configuration;
  protected IDbConnection conexion;

  public BaseRepository(IConfiguration configuration)
  {
    _configuration = configuration;
    var dbConfig = _configuration.GetSection("BaseDatos");
    string connectionString = $"Server={dbConfig["Servidor"]},{dbConfig["Puerto"]};Initial Catalog={dbConfig["NombreBase"]}"
     + $";MultipleActiveResultSets=true;User ID={dbConfig["Usuario"]};Password={dbConfig["Password"]}";

    conexion = new SqlConnection(connectionString);
    try
    {
      conexion.Open();
      conexion.Close();
    }
    catch 
    {
      throw new Exception("No se pudo conectar a la base de datos.");
    }
  }

  public void Dispose()
  {
    conexion.Dispose();
  }
}
