using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_mvc.WebApplication.Helpers
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<AutoMapperProfile>();
            });
        }
    }
}