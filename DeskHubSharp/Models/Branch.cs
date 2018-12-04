using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHubSharp
{
    public class Branch
    {
        public string name { get; set; }

        public Commit commit { get; set; }

        public class Commit
        {
            public string sha { get; set; }
            public string url { get; set; }
        }

    }
}
