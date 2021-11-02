﻿using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<Create_FilmeDto, Filme>();
            CreateMap<Filme, Read_FilmeDto>();
            CreateMap<Update_FilmeDto, Read_FilmeDto>();
        }
    }
}
