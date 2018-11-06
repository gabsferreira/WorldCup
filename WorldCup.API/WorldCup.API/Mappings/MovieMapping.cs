using AutoMapper;
using System;
using WorldCup.API.Models;
using WorldCup.API.ViewModels;
using WorldCupAPI.Models;

namespace WorldCup.API.Mappings
{
    public class MovieMapping : Profile
    {
        public MovieMapping()
        {
            CreateMap<MovieViewModel, Movie>()
                .ForMember(m => m.Rating, vm => vm.MapFrom(x => Convert.ToDouble(x.Nota)))
                .ForMember(m => m.Title, vm => vm.MapFrom(x => x.Titulo ))
                .ForMember(m => m.Year, vm => vm.MapFrom(x => x.Ano));

            CreateMap<Cup, CupViewModel>()
                .ForMember(m => m.Champion, vm => vm.MapFrom(x => x.Champion.Title))
                .ForMember(m => m.SecondPlace , vm => vm.MapFrom(x => x.SecondPlace.Title));
        }
    }
}
