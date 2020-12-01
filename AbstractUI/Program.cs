using LibraryAbstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //LogToScreen screen = new LogToScreen();
            //screen.FirstName = "Toon";
            //screen.LastName = "ToonLN";
            //screen.Log("I have added new record to the database");

            AbstractLogToFile file = new AbstractLogToFile();
            file.FirstName = "Toon";
            file.LastName = "ToonLN";
            file.Log("I have added new record to the database");
        }
    }
}
