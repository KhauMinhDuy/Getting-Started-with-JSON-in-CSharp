using JsonSamples;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2
{
    public class ConversionErrorsDemo
    {
        public static void Show()
        {
            Console.WriteLine("*** Conversion Errors with Delegate ***");

            string jsonDates = Generate.DatesJson();

            List<string> errors = new List<string>();

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Error = delegate (object sender, ErrorEventArgs errorArgs)
                {
                    errors.Add(errorArgs.ErrorContext.Error.Message);
                    errorArgs.ErrorContext.Handled = true;
                },
                Converters = { new IsoDateTimeConverter() }
            };

            List<DateTime> deserializedDates = JsonConvert.DeserializeObject<List<DateTime>>(jsonDates, settings);

            Console.WriteLine("Dates:");
            foreach (DateTime date in deserializedDates)
            {
                Console.WriteLine(date.ToShortDateString());
            }

            Console.WriteLine("Errors:");
            foreach (var err in errors)
            {
                Console.WriteLine(err);
            }
        }
    }
}