using AutoMapper;
using band_name_entity;
using band_name_web_api.Controllers.DTOs;

namespace band_name_web_api.Maps;

public class BandProfile: Profile
{
  public BandProfile()
  {
    CreateMap<Band, BandDTO>()
      .ForMember(des => des.id, opt => opt.MapFrom(src => src.id.Trim()))
      .ForMember(des => des.name, opt => opt.MapFrom(src => src.name.Trim()))
      .ReverseMap()
      .ForMember(des => des.name, opt => opt.MapFrom(src => src.name.Trim()));
  }
}
