using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar) {
        
        int total = 0;
        int arrayMin = 0;
        int arrayCount = 0;

        if (ar.Length > arrayMin ){

            foreach(int integer in ar){
 
                if (integer <= 1000){
                    
                    total += integer;
                }

                else{

                    Console.WriteLine($"Integer at array postion of {arrayCount} is out of range with a value of {integer}");
                    return total = 0;
                }

                arrayCount ++;

            }
            return total;
        }

        else{
            Console.WriteLine($"Array length out of range with a value of {ar.Length}");
            return total = 0;
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
