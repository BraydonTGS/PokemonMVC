using System;
using System.Text.Json;
using ApiMvcTest.Models;

namespace ApiMvcTest.Data
{
    public class PokemonApiResponse : IPokemonApiResponse
    {
        // init client //
        private readonly string _apiURL = "https://pokeapi.co/api/v2/pokemon/";
        HttpClient client = new HttpClient();

        public Pokemon GetPokemon(string pokemon)
        {

            var repo = client.GetStringAsync(_apiURL + pokemon).Result;
            var response = JsonSerializer.Deserialize<PokemonApiResponseObj>(repo);

            var myPoke = new Pokemon()
            {
                name = response.name,
                abilities = response.abilities.Select(ability => ability.ability.name).ToList(),
                base_experience = response.base_experience,
                height = response.height,
                id = response.id,
                location_area_encounters = response.location_area_encounters,
                moves = response.moves.Select(move => move.move.name).ToList(),
                sprite = response.sprites.front_default,
                stats = response.stats.Select(stat => stat.base_stat).ToList(),
                types = response.types.Select(type => type.type.name).ToList(),
                weight = response.weight,

            };

            return myPoke;
        }
    }
}