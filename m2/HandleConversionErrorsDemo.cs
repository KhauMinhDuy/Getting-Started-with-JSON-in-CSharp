using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonSamples;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace m2
{
    public class HandleConversionErrorsDemo
    {
        public static void Show()
        {
            Console.WriteLine("*** HandleConversionErrors Demo ***");

            string jsonDates = Generate.DatesJson();

            List<string> errors = new List<string>();

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Error = HandleDeserializationError,
                Converters = { new IsoDateTimeConverter() }
            };

            List<DateTime> deserializedDates = JsonConvert.DeserializeObject<List<DateTime>>(jsonDates, settings);
            Console.WriteLine("Dates:");
            foreach (DateTime date in deserializedDates)
            {
                Console.WriteLine(date.ToShortDateString());
            }

        }

        private static void HandleDeserializationError(object sender, ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            Console.WriteLine(currentError);
            errorArgs.ErrorContext.Handled = true;
        }
    }
}