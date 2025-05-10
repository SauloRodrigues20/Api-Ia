using Azure;
using Azure.AI.OpenAi;
using Microsoft.Extensions.Configuration;
using OpenAi.Chat;
using System.Text;

namespace ConsoleApp.AzureAi{
    public class TemperatureSettings{
        public double Temperature {get; set;} = 0.7;
    }

    public class Program{
        private static string AzureOpenAiEndpoint = "";
        private static string AzureOpenAiKey = "";
        private static string DeploymentName = "";
    }
}