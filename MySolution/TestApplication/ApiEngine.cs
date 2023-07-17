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
            var resquestStr = string.Format("https://rickandmortyapi.com/api/character/?name={0}", name);
            try
            {
                var response = WebRequest.CreateHttp(resquestStr).GetResponse().GetResponseStream();
                var store = new StreamReader(response);
                var data = store.ReadToEnd();
                var jsonData = JsonNode.Parse(data)["results"];
                var K = jsonData.Deserialize<List<Character>>();
                
                character.image = K.First().image;
                character.name = K.First().name;

            }
            catch (Exception e) { }
            

                
            

            
            return character;
        }

        public static List<Character> SearchCharacters(string name)
        {


            var searchResults = new List<Character>();
            
            var resquestStr = string.Format("https://rickandmortyapi.com/api/character/?name={0}", name);
            try
            {
                var response = WebRequest.CreateHttp(resquestStr).GetResponse().GetResponseStream();
                var store = new StreamReader(response);
                var data = store.ReadToEnd();
                var jsonData = JsonNode.Parse(data)["results"];
                searchResults = jsonData.Deserialize<List<Character>>();
                
               

            }
            catch (Exception e) { }
            return searchResults;
        }
    }
}
