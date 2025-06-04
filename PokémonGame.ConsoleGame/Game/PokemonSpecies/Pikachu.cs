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
        public Pikachu(int level, List<Attack> attacks)
            : base("Pikachu", level, attacks) { }

        public void Evolve()
        {
            string oldName = Name;
            Name = "Raichu";
            Level += 10;
            Console.WriteLine($"{oldName} is evolving... Now it's {Name}! Level {Level}!");
        }
    }
}
