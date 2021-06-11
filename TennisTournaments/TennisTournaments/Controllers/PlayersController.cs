using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisTournaments.Data;
using TennisTournaments.Models;
using TennisTournaments.Services;

namespace TennisTournaments.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayersService playersService;
        public PlayersController(IPlayersService service)
        {
            this.playersService = service;
        }

        [HttpGet]
        public IEnumerable<PlayerOutputModel> Get()
        {
            return this.playersService.GetAllPlayers();
        }
    }
}
