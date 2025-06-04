using PokémonGame.ConsoleGame.Game.PokemonSpecies;
using PokémonGame.ConsoleGame.Game.Subclass;
using PokémonGame.ConsoleGame.Interfaces;

//Predefined attacks
//Fire
var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
var ember = new Attack("Ember", ElementType.Fire, 6);
//Water
var waterGun = new Attack("Water Gun", ElementType.Water, 10);
var surf = new Attack("Surf", ElementType.Water, 5);
//Electric
var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 10);
var spark = new Attack("Spark", ElementType.Electric, 7);

//Create Pokémon
var charmander = new Charmander(5, new List<Attack> { flamethrower, ember });
var squirtle = new Squirtle(8, new List<Attack> { waterGun, surf });
var pikachu = new Pikachu(14, new List<Attack> { thunderbolt, spark });

//Create list of Pokémon
var listPokemons = new List<Pokemon> { charmander, squirtle, pikachu};


#region Test Reflection Question 4
//Test Reflection Question 4. What happens if you try to add a Charmander to a list that only allows WaterPokemon?
//var waterPokemons = new List<WaterPokemon>();

//var charmanderWater = new Charmander(5, new List<Attack> { flamethrower, ember });

//waterPokemons.Add(charmanderWater);


#endregion
foreach (var pokemon in listPokemons)
{
    pokemon.RaiseLevel();
    //Kör RandomAttack istället för Attack så jag får samma output som i exempel output
    //pokemon.Attack();
    pokemon.RandomAttack();

    if (pokemon is IEvolvable evolvable)
    {
        evolvable.Evolve();
    }
}




