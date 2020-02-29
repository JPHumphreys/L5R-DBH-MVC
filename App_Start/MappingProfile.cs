using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using L5R_DBH_MVC.Dtos;
using L5R_DBH_MVC.Models;

namespace L5R_DBH_MVC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //API -> Outbound

            Mapper.CreateMap<Card, CardDto>();



            //API <- Inbound
            Mapper.CreateMap<CardDto, Card>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }

    }
}