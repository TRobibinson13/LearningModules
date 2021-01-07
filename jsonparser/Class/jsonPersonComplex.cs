using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Just a placeholder for sample JSON to work with
{
  "firstname" : "Roger",
  "lastname" : "Moore",
  "age" : 89,
  "isAlive" : false,
  "address" :
  {
    "streetAddress" : "1 Main Street",
    "city" : "London",
    "postCode" : "N1 3XX"
  }
}
 */

namespace JSONParser
{
    class jsonPersonComplex : jsonPersonSimple
    {
        /*
         * Pre-inheretence code.  Adding inheretence wasn't part of tutorial but a fun additional test
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public Boolean isAlive { get; set; }
        */

        public addr address { get; set; }

        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string postCode { get; set; }
        }
    }
}
