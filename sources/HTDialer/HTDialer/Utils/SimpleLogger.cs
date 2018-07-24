using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * @author AlexandrinK <aks@cforge.org>
 */
namespace HTDialer.Utils
{
    public class SimpleLogger
    {

        public static void Log(String message)
        {
            File.AppendAllText("log.txt", message + Environment.NewLine);
        }
    }
}
