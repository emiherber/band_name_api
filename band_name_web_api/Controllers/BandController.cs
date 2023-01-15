using AutoMapper;
using band_name_entity;
using band_name_repository_interface;
using band_name_web_api.Controllers.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace band_name_web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class BandController : ControllerBase
{
  private readonly IMapper _IMapper;
  private readonly BandRepositoryInterface _IBandRepository;

  public BandController(IMapper IMapper, BandRepositoryInterface IBandRepositoryInterface) {
    _IMapper = IMapper;
    _IBandRepository = IBandRepositoryInterface;
  }

  [HttpGet(Name = "GetAll")]
  public async Task<IEnumerable<BandDTO>> GetAll() 
  {
    List<Band> bands = await _IBandRepository.getAll();
    return _IMapper.Map<List<BandDTO>>(bands);
  }
}
