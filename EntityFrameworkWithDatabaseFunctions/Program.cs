using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkWithDatabaseFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new TestModel();
            var result = dbContext.Foos.Select(f => TestModel.ConcatenateText(f.name, "AddedText"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
