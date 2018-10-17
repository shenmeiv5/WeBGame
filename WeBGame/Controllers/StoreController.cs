using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WeBGame.Models;
using WeBGame.Service;

namespace WeBGame.Controllers
{
    public class StoreController : Controller
    {

        private IGameService _service;

        public StoreController(IGameService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            List<GameViewModel> gameViewModels = getGameViewModels();
            return View("Store", gameViewModels);
        }

        public IActionResult Good(long id)
        {
            Game game = new Game();
            return View("Good");
        }

        private List<GameViewModel> getGameViewModels()
        {
            List<Game> games = _service.GetGames();
            List<GameViewModel> gameViewModels = new List<GameViewModel>();
            foreach (var game in games)
            {
                List<GameResource> resources = _service.GetResourcesForGame(game.Id);
                gameViewModels.Add(new GameViewModel(game, resources));
            }

            return gameViewModels;
        }
    }
}