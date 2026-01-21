using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Core
{
    public static class HelloFactory
    {

        public static string CreateHelloMessage(string name)
        {
            return $"Hello, {name}!";
        }

    }
}
