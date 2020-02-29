﻿using AutoMapper;
using L5R_DBH_MVC.Dtos;
using L5R_DBH_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace L5R_DBH_MVC.Controllers.Api
{
    public class CardsController : ApiController
    {
        private ApplicationDbContext _context;

        public CardsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/cards
        [HttpGet]
        public List<CardDto> GetCards(string query = null)
        {
            return _context.Cards.ToList().Select(Mapper.Map<Card, CardDto>).ToList();
                
        }
    }
}
