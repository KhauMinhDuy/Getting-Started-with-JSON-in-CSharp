using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSamples
{
    public class Generate
    {
        public static string SingleJson()
        {
            return File.ReadAllText("AuthorSingle.json");
        }
    }
}
