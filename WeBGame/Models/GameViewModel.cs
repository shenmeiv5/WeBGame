using System.Collections.Generic;

namespace WeBGame.Models
{
    public class GameViewModel
    {
        public GameViewModel(Game game, List<GameResource> resources, int price)
        {
            Game = game;
            Resources = resources;
            Price = price;
        }

        public Game Game { get; set; }
        public List<GameResource> Resources { get; set; }
        public int Price { get; set; }
    }
}