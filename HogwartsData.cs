using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trinug
{
    public class Person {
        public string Name { get; set; }
    }
    public static class HogwartsData
    {
        [FunctionName("HogwartsData")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var list = new List<Person>();
            list.Add(new Person { Name = "Hermoine Granger" });
            list.Add(new Person { Name = "Harry Potter" });
            list.Add(new Person { Name = "Ron Weasley" });
            list.Add(new Person { Name = "Draco Malfoy" });
            list.Add(new Person { Name = "Lord Voldemort" });
            list.Add(new Person { Name = "Albus Dumbledore" });
            return new OkObjectResult(list);
        }
    }
}
