using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO = Project_mvc.Database;
using DTO = Project_mvc.Service.ModelsDTO;
using ViewModel = Project_mvc.WebApplication.Models;

namespace Project_mvc.WebApplication.Helpers
{

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ViewModel.StudentViewModel, DTO.StudentDTO >()
                .ForMember(
                    dest => dest.imie,
                    opt => opt.MapFrom(src => src.Name)
                )
                .ForMember(
                    dest => dest.nazwisko,
                    opt => opt.MapFrom(src => src.Email)
                )
                .ForMember(
                    dest => dest.pesel,
                    opt => opt.MapFrom(src => src.Surname)
                );
            CreateMap<DTO.StudentDTO, DAO.Student>();
            CreateMap<DAO.Student, DTO.StudentDTO>();
        }
    }
}