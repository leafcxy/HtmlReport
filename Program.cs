using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReportProcess.Instance.PrintReport("hello world!", 48, 0, null);
            //ReportProcess.Instance.PrintReport("hello world!", 48, 0, "Microsoft Print to PDF");
            ReportProcess.Instance.PrintReport(GetResourceHTMLResourceFileFromLocal("hello.html"), 48, 48, "Microsoft Print to PDF");
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        /// <summary>
        /// 从当前资源读取文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        internal static string GetResourceHTMLResourceFileFromLocal(string fileName)
        {
            string resource = null;
            string file = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (System.IO.File.Exists(file))
            {
                using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        resource = sr.ReadToEnd();
                    }
                }
                return resource;
            }
            else
            {
                return "";
                //return GetResourceFileContentAsString(fileName);
            }
        }
    }
}
