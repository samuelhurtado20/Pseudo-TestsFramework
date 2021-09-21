using System;

namespace Pseudo_TestsFramework{
    public class CustomAsset{
        public static bool AreEqual(object a, object b){
            return a.GetType() == b.GetType() && a.Equals(b);
        }
        
        public static bool AreEqual(bool a, bool b){
            return a && b;
        }
        
        public static bool StringContains(string s, string search){
            return s.Contains(search);
        }
    } 
}