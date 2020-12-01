using LibraryAbstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAbstractions.Models
{
    public class LogToScreen: Parent, Ilogger
    {
       public void Log(string message)
       {
            Console.WriteLine($"{message} by: {FirstName} {LastName}");
       }
    }
}
