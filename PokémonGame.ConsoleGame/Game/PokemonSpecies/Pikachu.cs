using PokémonGame.ConsoleGame.Game.Subclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonGame.ConsoleGame.Game.PokemonSpecies
{
    public class Pikachu : ElectricPokemon
    {
        public Pikachu(string name, int level, List<Attack> attacks)
            : base("Pikachu", level, attacks) { }
    }
}
