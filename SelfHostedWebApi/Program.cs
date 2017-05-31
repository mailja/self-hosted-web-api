using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace SelfHostedWebApi
{
  class Program
  {
    static void Main(string[] args) {
      WebApp.Start<Startup>("http://localhost:5000/");
      Console.ReadLine();
    }
  }
}
