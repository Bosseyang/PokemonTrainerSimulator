using PokémonGame.ConsoleGame.Game.Subclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonGame.ConsoleGame.Game.PokemonSpecies
{
    public class Charmander : FirePokemon
    {
        public Charmander(int level, List<Attack> attacks)
            : base("Charmander", level, attacks) { }
    }
}
