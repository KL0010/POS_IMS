using IMS;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;


class Program
{
    static async Task Main()
    {
        await ProcessRepositoriesAsync();
    }

    static HttpClientHandler DefaultHandler()
    {
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

        return clientHandler;
    }

    static void PrintMenu()
    {
        Console.WriteLine("---------------------------- Inventory Management System -------------------------");
        Console.WriteLine();
        Console.WriteLine("1. Get Roles");
        Console.WriteLine("2. Get Role");
    }

    static void PrintOutcome(JsonArray json)
    {
        foreach (var data in json)
        {
            Console.WriteLine($"{data}\n");
        }
    }

    static async Task GetRoles(HttpClient client)
    {
        Console.WriteLine();
        HttpResponseMessage response = await client.GetAsync("https://192.168.1.103:7276/");
        if (response.IsSuccessStatusCode)
        {
            // Deserialize the JSON response and process the data
            // (You can use libraries like Newtonsoft.Json for deserialization)
            var jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonResponse);

            //Console.WriteLine($"{jsonResponse}\n");
            foreach (var data in jsonObject)
            {
                Console.WriteLine($"Role ID: {data.roleId}, roleName: {data.roleName}, description: {data.description} \n");
            }
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }
    }

    static async Task ProcessRepositoriesAsync()
    {
        HttpClientHandler clientHandler = DefaultHandler();
        string input = "";
        PrintMenu();
        using HttpClient client = new HttpClient(clientHandler);
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

        while (input != "Q")
        {

            switch (input)
            {
                case "":
                    Console.Write("Enter Selection: ");
                    input = Console.ReadLine();
                    break;
                case "1":
                    await GetRoles(client);
                    input = "Q";
                    break;
            }
        }
    }
}

