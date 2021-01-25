using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTW_Webserver.Controllers.StoreFile
{
    public class StoreFileRequest
    {
        public string Data { get; set; }
        public IEnumerable<string> Pessoas { get; set; }
    }
}
