﻿using System.Linq;
using JsonSamples;
using Newtonsoft.Json;
using System;

namespace m2
{
    public class SerializeDeserializeDemo
    {
        public static void Show()
        {
            string jsonSample = Generate.SingleJson();

            /*---------------------------------------------------------*/
            Console.WriteLine($"Step 1: Output Json");
            Console.WriteLine(jsonSample);

            /*---------------------------------------------------------*/
            Console.WriteLine(Environment.NewLine + "Step 2: Output Property Author.Name from deserialized class");
            Author xavierAuthor = JsonConvert.DeserializeObject<Author>(jsonSample);
            Console.WriteLine(xavierAuthor.Name);
            Console.WriteLine(xavierAuthor.Courses.Count());

            /*---------------------------------------------------------*/
            Console.WriteLine(Environment.NewLine + "Step 3: Output serialized Author class");
            string xavierJsonSerialized = JsonConvert.SerializeObject(xavierAuthor);
            Console.WriteLine(xavierJsonSerialized);

            /*---------------------------------------------------------*/
            Console.WriteLine(Environment.NewLine + "Step 4: Output serialized Author class with indentation");
            string xavierJsonSerializedIndented = JsonConvert.SerializeObject(xavierAuthor, Formatting.Indented);
            Console.WriteLine(xavierJsonSerializedIndented);


        }
    }
}
