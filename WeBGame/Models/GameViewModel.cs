using System.Collections.Generic;

namespace WeBGame.Models
{
    public class GameViewModel
    {
        public GameViewModel(Game game, List<GameResource> resources)
        {
            Game = game;
            Resources = resources;
        }

        public Game Game { get; set; }
        public List<GameResource> Resources { get; set; }
    }
}