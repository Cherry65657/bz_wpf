using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bz_wpf
{
    class LnkRend
    {   
        
        public static List<string> GetLnkRend() {
            List<string> fnl = new List<string>() { };
            string[] dir = Directory.GetDirectories(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs");

            foreach (string  item in dir)
            {
                
                string[] strFiles = Directory.GetFiles(item, "*.lnk");
           
                if (strFiles.Length == 0)
                {
                    
                }
                foreach (string item1 in strFiles)
                {
                    fnl.Add(item1);
                }

            }
           
            return fnl;
        }
        
    }
}
