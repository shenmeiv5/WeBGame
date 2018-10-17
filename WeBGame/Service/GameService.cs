using System.Collections.Generic;
using WeBGame.Models;
using WeBGame.Repositories;

namespace WeBGame.Service
{
    public class GameService : IGameService
    {

        private readonly IGameRepository _gameRepository;
        private readonly IGameResourceRepository _resourceRepository;

        public GameService(IGameRepository gameRepository, IGameResourceRepository resourceRepository)
        {
            _gameRepository = gameRepository;
            _resourceRepository = resourceRepository;
        }

        public List<Game> GetGames()
        {
            return _gameRepository.GetAllGames();
        }

        public List<GameResource> GetResourcesForGame(long gameId)
        {
            return _resourceRepository.GetResourcesForGame(gameId);
        }
    }
}