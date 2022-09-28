using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JsonSamples;
using Newtonsoft.Json;

namespace m2
{
    public class JsonTextReaderDemo
    {
        public static void Show()
        {
            Console.WriteLine("*** JsonTextReader Demo ***");
            string jsonSample = Generate.SingleJson();

            JsonTextReader jsonReader = new JsonTextReader(new StringReader(jsonSample));
            while (jsonReader.Read())
            {
                if (jsonReader.Value != null)
                {
                    Console.WriteLine($"Token: {jsonReader.TokenType}, Value: {jsonReader.Value}");
                }
                else
                {
                    Console.WriteLine($"Token: {jsonReader.TokenType}");
                }
            }

        }
    }
}