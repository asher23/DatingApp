using DatingApp.API.Dtos;
using DatingApp.API.Models;
using AutoMapper;
using System.Linq;

namespace DatingApp.API.Helpers
{
  public class AutoMapperProfiles : Profile
  {
    public AutoMapperProfiles()
    {
      CreateMap<User, UserForDetailedDto>()
        .ForMember(dest => dest.PhotoUrl, opt =>
        {
          opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
        })
        .ForMember(dest => dest.Age, opt =>
        {
          opt.ResolveUsing(d => d.DateofBirth.CalculateAge());
        });
      CreateMap<User, UserForListDto>()
        .ForMember(dest => dest.PhotoUrl, opt =>
        {
          opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
        })
        .ForMember(dest => dest.Age, opt =>
        {
          opt.ResolveUsing(d => d.DateofBirth.CalculateAge());
        });
      CreateMap<Photo, PhotosForDetailedDto>();
      CreateMap<Photo, PhotoForReturnDto>();
      CreateMap<PhotoForCreationDto, Photo>();
    }
  }
}