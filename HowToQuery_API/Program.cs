using HowToQuery_API;
using Newtonsoft.Json;
using RestSharp;

var client = new RestClient("https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/npm-covid-data/");
var request = new RestRequest();
request.AddHeader("X-RapidAPI-Key", "074ffd9f62mshfab1a752b7e2342p1f409fjsnbc7bc16069e0");
var response = client.Execute(request).Content;

var root = JsonConvert.DeserializeObject<List<Covid_Root>>(response);

foreach (var item in root)
{
    Console.WriteLine(item.Country);
    Console.WriteLine(item.id);
    Console.WriteLine(item.rank);
    Console.WriteLine(item.Continent);
    Console.WriteLine(item.TwoLetterSymbol);
    Console.WriteLine(item.ThreeLetterSymbol);
    Console.WriteLine(item.Infection_Risk);
    Console.WriteLine(item.Case_Fatality_Rate);
    Console.WriteLine(item.Test_Percentage);
    Console.WriteLine(item.Recovery_Proporation);
    Console.WriteLine(item.TotalCases);
    Console.WriteLine(item.NewDeaths);
    Console.WriteLine(item.TotalRecovered);
    Console.WriteLine(item.NewRecovered);
    Console.WriteLine(item.ActiveCases);
    Console.WriteLine(item.TotalTests);
    Console.WriteLine(item.Population);
    Console.WriteLine(item.one_Caseevery_X_ppl);
    Console.WriteLine(item.one_Deathevery_X_ppl);
    Console.WriteLine(item.one_Testevery_X_ppl);
    Console.WriteLine(item.Deaths_1M_pop);
    Console.WriteLine(item.Serious_Critical);
    Console.WriteLine(item.Tests_1M_Pop);
    Console.WriteLine(item.TotCases_1M_Pop);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("=====================================");
}