using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace IntegraBrasilApi.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoModel, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}