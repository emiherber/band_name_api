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

    conexion = new SqlConnection(connectionString: _configuration["ConnectionStrings:SqlConnection"]);
    try
    {
      conexion.Open();
      conexion.Close();
    }
    catch(Exception e)
    {
      // throw new Exception("No se pudo conectar a la base de datos.");
      throw e;
    }
  }

  public void Dispose()
  {
    conexion.Dispose();
  }
}
