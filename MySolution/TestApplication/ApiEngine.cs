using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestApplication
{
    public static class ApiEngine
    {
        public static Character GetCharacter(string name)
        {
            var character = new Character();

            // Implement api call here


            return character;
        }

        public static List<Character> SearchCharacters(string name)
        {


            var searchResults = new List<Character>();

            return searchResults;
        }
    }
}
