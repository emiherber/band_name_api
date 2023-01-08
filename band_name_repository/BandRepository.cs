using band_name_entity;
using band_name_repository_interface;
using Microsoft.Extensions.Configuration;

namespace band_name_repository;

public class BandRepository : BaseRepository, BandRepositoryInterface
{
  public BandRepository(IConfiguration configuration) : base(configuration)
  {
  }

  public Task delete(string id)
  {
    throw new NotImplementedException();
  }

  public Task insert(string name)
  {
    throw new NotImplementedException();
  }

  public Task<List<Band>> getAll()
  {
    throw new NotImplementedException();
  }
}
