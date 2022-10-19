using System;
using ApiMvcTest.Data;
using Type = ApiMvcTest.Data.Type;

namespace ApiMvcTest.Models
{
    public class Pokemon
    {
        public List<string> abilities { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public List<object> held_items { get; set; }
        public int id { get; set; }
        public string? location_area_encounters { get; set; }
        public List<string> moves { get; set; }
        public string? name { get; set; }
        public int order { get; set; }
        public List<object> past_types { get; set; }
        public string sprite { get; set; }
        public List<int> stats { get; set; }
        public List<string>? types { get; set; }
        public int weight { get; set; }
    }
}

