using System;
using System.Collections.Generic;
using System.Text;

namespace servicedocker
{
    public class ServiceConfigurations
    {
        public string LogDatabase { get; set; }
        public string[] Hosts { get; set; }
        public int Intervalo { get; set; }
    }
}
