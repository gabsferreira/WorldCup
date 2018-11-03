using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        }
    }
}
