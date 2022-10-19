using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMvcTest.Data;
using ApiMvcTest.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMvcTest.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonApiResponse _response;

        public PokemonController(IPokemonApiResponse response)
        {
            _response = response;
        }

        public IActionResult SearchForPokemon()
        {

            return View();
        }

        public IActionResult Index()
        {
            var searchString = Request.Form["searchString"];
            var myPokemon = _response.GetPokemon(searchString);
            Pokemons.AddToList(myPokemon);
            return View(myPokemon);

        }

        public IActionResult DisplayAllPokemon()
        {
            return View();
        }

    }


}

