﻿using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class FeedbackService
    {
        public static List<FeedbackDTO> Get()
        {
            var data = DataAccessFactory.FeedbackData().Read();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Feedback, FeedbackDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<FeedbackDTO>>(data);
            return mapped;
        }


        public static FeedbackDTO Get(int id)
        {
            var data = DataAccessFactory.FeedbackData().Read(id: id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Feedback, FeedbackDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeedbackDTO>(data);
            return mapped;
        }


    }
}
