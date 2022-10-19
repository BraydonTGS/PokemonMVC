using ApiMvcTest.Models;

namespace ApiMvcTest.Data
{
    public interface IPokemonApiResponse
    {
        public Pokemon GetPokemon(string pokemon);

    }
}