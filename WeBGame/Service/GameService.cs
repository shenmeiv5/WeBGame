using System.Collections.Generic;
using WeBGame.Models;
using WeBGame.Repositories;

namespace WeBGame.Service
{
    public class GameService : IGameService
    {

        private readonly IGameRepository _gameRepository;
        private readonly IGameResourceRepository _resourceRepository;
        private readonly ISalesRepository _salesRepository;

        public GameService(IGameRepository gameRepository, IGameResourceRepository resourceRepository, ISalesRepository salesRepository)
        {
            _gameRepository = gameRepository;
            _resourceRepository = resourceRepository;
            _salesRepository = salesRepository;
        }

        public List<Game> GetGames()
        {
            return _gameRepository.GetAllGames();
        }

        public Game GetGameByID(int gameID)
        {
            return _gameRepository.GetGame(gameID);
        }

        public List<GameResource> GetResourcesForGame(int gameId)
        {
            return _resourceRepository.GetResourcesForGame(gameId);
        }

        public GameSales GetSaleForGame(int gameId)
        {
            return _salesRepository.GetSaleForGame(gameId);
        }
    }
}