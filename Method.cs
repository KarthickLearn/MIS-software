using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
namespace MIS
{
    internal class Method
    {
    


        private Method()
        {

        }
        public static Method obj;

        public static Method Getobj()
        {
            if(obj == null)
            obj = new Method();
            return obj;
        }


       public void FolderCreation( string path, string foldername)
        {

           
            DirectoryInfo dcf = new DirectoryInfo(@path + "/" + foldername);

            
                if (dcf.Exists) { 
     

                }
                else
                {
                    dcf.Create();

                }
            

          

        }


        public static int restrict = 0;
        public void Choosefile(string fpath, string ffile)
        {
            
            if (File.Exists(fpath + "/" + ffile) == false)
            {

                
                Openfilefolder ofp = new Openfilefolder();
                ofp.fun = fpath + "/" + ffile;
               
                    restrict++;
                    ofp.Show();
               
                
                ofp.Filename(ffile);

            }
            else
            {

            }



        }

        public void Unzip(String zippatfile, String extractpath)
        {
             
            ZipFile.ExtractToDirectory(zippatfile, extractpath); 
            
             }







        internal void FolderCreation(dynamic dynamic, int v)
        {
            throw new NotImplementedException();
        }
    }

}
