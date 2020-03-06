using AutoMapper;
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
        public IHttpActionResult GetCards()
        {
            var cards = _context.Cards.ToList();
            var ratings = _context.Ratings.ToList();

            var returnValue = (from c in cards
                               join r in ratings on c.Id equals r.Id
                               select new
                               {
                                   id = c.Id,
                                   name = c.Name,
                                   cost = c.Cost,
                                   deckLimit = c.DeckLimit,
                                   fate = c.Fate,
                                   glory = c.Glory,
                                   honor = c.Honor,
                                   influenceCost = c.InfluenceCost,
                                   influencePool = c.InfluencePool,
                                   military = c.Military,
                                   militaryBonus = c.MilitaryBonus,
                                   political = c.Political,
                                   politicalBonus = c.PoliticalBonus,
                                   strength = c.Strength,
                                   strengthOf = c.StrengthOf,
                                   isBanned = c.IsBanned,
                                   isRestricted = c.IsRestricted,
                                   unicity = c.Unicity,
                                   clan = c.Clan,
                                   element = c.Element,
                                   roleRestriction = c.RoleRestriction,
                                   side = c.Side,
                                   cardType = c.CardType,
                                   imageLocation = c.ImageLocation,
                                   text = c.Text,
                                   overallRating = r.OverallRating,
                                   crabRating = r.CrabRating,
                                   craneRating = r.CraneRating,
                                   dragonRating = r.DragonRating,
                                   lionRating = r.LionRating,
                                   phoenixRating = r.PhoenixRating,
                                   scorpionRating = r.ScorpionRating,
                                   unicornRating = r.UnicornRating,
                                   crabTotalVotes = r.CrabTotalVotes,
                                   craneTotalVotes = r.CraneTotalVotes,
                                   dragonTotalVotes = r.DragonTotalVotes,
                                   lionTotalVotes = r.LionTotalVotes,
                                   phoenixTotalVotes = r.PhoenixTotalVotes,
                                   scorpionTotalVotes = r.PhoenixTotalVotes,
                                   unicornTotalVotes = r.UnicornTotalVotes

                               }).ToList();

            return Ok(returnValue);
  
        }
    }
}
