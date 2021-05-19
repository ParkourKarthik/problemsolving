using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
        String v = Console.ReadLine();
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=0; i< v.Length; i++){
            String person = Console.ReadLine();
            bool infected = isSubsequence(person, v, person.Length, v.Length);
            if(infected)
                Console.WriteLine("POSITIVE");
            else
                Console.WriteLine("NEGATIVE");
        }
    
    }

    private static bool isSubsequence(String p, String v, int pc, int vc)
    {
        if(pc==0)
            return true;
        if(vc==0)
            return false;

        
        if(p[pc-1] == v[vc-1])
            return isSubsequence(p, v, pc-1, vc-1);

        return isSubsequence(p, v, pc, vc-1);
    }
}
