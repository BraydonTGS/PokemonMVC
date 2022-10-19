using System;
namespace ApiMvcTest.Models
{
    public class Pokemons
    {
        public static List<Pokemon> PokeList = new List<Pokemon>();

        public static void AddToList(Pokemon pokemon)
        {
            PokeList.Add(pokemon);
        }

    }
}

