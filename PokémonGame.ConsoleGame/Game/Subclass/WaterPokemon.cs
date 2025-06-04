using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonGame.ConsoleGame.Game.Subclass
{
    public class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, attacks)
        {
            Type = ElementType.Water;
        }
    }
}
