using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAbstractions.Models
{
    public class AbstractLogToScreen:AbstractParent
    {      
        public override void Log(string message)
        {
            Console.WriteLine($"{message} by: {FirstName} {LastName}");
        }
    }
}
