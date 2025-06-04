using PokémonGame.ConsoleGame.Game.Subclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonGame.ConsoleGame.Game.PokemonSpecies
{
    public class Squirtle : WaterPokemon
    {
        public Squirtle(string name, int level, List<Attack> attacks)
            : base("Squirtle", level, attacks) { }
    }
}
