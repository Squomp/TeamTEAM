using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaServiceLib;
using MediaServiceLib.Service;

namespace DBAndServiceLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MediaService service = new MediaService();
            service.GetAllMedia().MediaList.ForEach(x => Console.WriteLine(x.Author));
        }
    }
}
