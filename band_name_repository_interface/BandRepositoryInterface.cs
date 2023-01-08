using band_name_entity;

namespace band_name_repository_interface;

public interface BandRepositoryInterface
{
  Task insert(string name);
  Task delete(string id);
  Task<List<Band>> getAll();
}
