using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Downloaders
    {
        WebClient client = new WebClient();
        string _url;
        string _path;
        public Downloaders(string Url , string path)
        {
            _url = Url;
            _path = path; 
        }
        public bool DownloadFile()//установка файла 
        {
            try { 
                client.DownloadData(_url);
                string filename = client.ResponseHeaders["Content-Disposition"]
                    .Substring(client.ResponseHeaders["Content-Disposition"]
                    .IndexOf("filename=")+30).Replace("\"","");  
                filename = filename.Replace("%", "");
                client.DownloadFileAsync(new Uri(_url), _path + "\\" + filename);
           
                Console.WriteLine(filename);
            
            return true;
            }
            catch
            {
                return false;
            }
           
        }
        
    }
}
