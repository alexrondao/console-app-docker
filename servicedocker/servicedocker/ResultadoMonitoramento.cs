using System;
using System.Collections.Generic;
using System.Text;

namespace servicedocker
{
    public class ResultadoMonitoramento
    {
        //public ObjectId _id { get; set; }
        public string _id { get; set; }
        public string Horario { get; set; }
        public string Host { get; set; }
        public string Status { get; set; }
        //[BsonIgnoreIfNull]
        public object Exception { get; set; }
    }
}
