using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisTournaments.Models;
using TennisTournaments.Services;

namespace TennisTournaments.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TournamentsController : ControllerBase
    {
        private readonly ITournamentsService tournamentsService;
        public TournamentsController(ITournamentsService service)
        {
            this.tournamentsService = service;
        }

        [HttpGet]
        public IEnumerable<TournamentOutputModel> Get()
        {
            return tournamentsService.GetAllTournaments();
        }
    }
}
