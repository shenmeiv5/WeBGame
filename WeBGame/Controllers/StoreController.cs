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
            List<GameViewModel> gameViewModels = GetGameViewModels();
            return View("Store", gameViewModels);
        }

        public IActionResult Good(int ig)
        {
            GameViewModel gameView = GetGameViewModel(ig);
            if (gameView == null)
                return Index();
            return View("Good", gameView);
        }

        private List<GameViewModel> GetGameViewModels()
        {
            List<Game> games = _service.GetGames();
            List<GameViewModel> gameViewModels = new List<GameViewModel>();
            foreach (var game in games)
            {
                gameViewModels.Add(GetGameViewModel(game.Id, game));
            }

            return gameViewModels;
        }

        private GameViewModel GetGameViewModel(int gameID, Game g = null)
        {
            Game game = g ?? _service.GetGameByID(gameID);
            if (game == null)
                return null;
            List<GameResource> resources = _service.GetResourcesForGame(gameID);
            GameSales sales = _service.GetSaleForGame(gameID);
            GameViewModel gameViewModel = new GameViewModel(game, resources, (int)sales.SalePrice, sales.SaleDiscount);
            return gameViewModel;
        }
    }
}