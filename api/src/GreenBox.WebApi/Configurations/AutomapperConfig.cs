using AutoMapper;
using GreenBox.Business.Models;
using GreenBox.WebApi.ViewModels;

namespace GreenBox.WebApi.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Colaborador, ColaboradorViewModel>().ReverseMap();
        }
    }
}
