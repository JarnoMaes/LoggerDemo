using LibraryAbstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAbstractions.Models
{
    public class AbstractLogToFile:AbstractParent
    {
        public override void Log(string message)
        {
            var file = "LogFile.txt";
            File.WriteAllText(file, message + "by:" + FirstName + LastName);
        }
    }
}
