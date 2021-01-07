using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Just a placeholder for sample JSON to work with
{
  "firstname" : "Roger",
  "lastname" : "Moore",
  "age" : 89,
  "isAlive" : false,
}
 */

namespace JSONParser
{
    class jsonPersonSimple
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public Boolean isAlive { get; set; }
    }
}
