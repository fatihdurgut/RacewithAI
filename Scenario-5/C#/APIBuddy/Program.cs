// Scenario 5: API Integration
// You can run the code by 'dotnet run' command in terminal.

// Task1: Integrate RESTful API into your application
// Task2: Beautify the output of the API response

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        string objectData = await GetObjectDataAsync();
        Console.WriteLine(objectData);  // Should print the object data from the API
    }

    static async Task<string> GetObjectDataAsync()
    {
        string url = "https://api.restful-api.dev/objects/7";
        return "Sample output";
    }
}
