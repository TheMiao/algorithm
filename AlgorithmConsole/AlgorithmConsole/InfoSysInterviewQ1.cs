using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AlgorithmConsole
{
    public class InfoSysInterviewQ1
    {
        /// <summary>
        /// Start Up 
        /// </summary>
        public void StartUp()
        {
            Console.WriteLine("Start xml program.");
            Console.WriteLine("While running and waiting for input");
            // Split up the 3 arguments
            var arguments = InputArguments();
            var a1 = arguments[0];
            var a2 = arguments[1];
            var a3 = arguments[2];

            Search(a1, a3, a2);
            while (true)
            {
                string[] entrys = InputEntrys();
                Search(a1, a3, entrys);
            }
        }

        /// <summary>
        /// Return string array
        /// </summary>
        /// <returns>Return 3 values, inputFile path, Value, outputFile path</returns>
        private string[] InputArguments()
        {
            var inputStr = string.Empty;
            string[] arguments = { };
            var loop = true;
            while (loop)
            {
                // retrieve inputString from user
                inputStr = Console.ReadLine();
                // split up the inputString with 3 parts
                arguments = inputStr.Split(' ');
                if (arguments.Length == 3)
                {
                    // check if the xml file exist or not.
                    if (!File.Exists(arguments[0]))
                    {
                        Console.WriteLine("XML file dosen't exist. Please input again.");
                        continue;
                    }
                    try
                    {
                        // use the output file path creat or open the outputFile.
                        using (FileStream fs = new FileStream(arguments[2], FileMode.OpenOrCreate, FileAccess.Write))
                        {

                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Output file Directory rejected. Please input again.");
                        continue;
                    }

                    loop = false;
                }
                else
                {
                    Console.WriteLine("Input error.Please input again.");
                }
            }
            return arguments;
        }

        /// <summary>
        /// Search function for xamlFile
        /// </summary>
        /// <param name="xmlFile">input xml File path</param>
        /// <param name="outFile">output file path</param>
        /// <param name="a2">input value for serach</param>
        private void Search(string xmlFile, string outFile, params string[] a2)
        {
            // initialise the xml
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);

            // loop through the a2 intput value
            foreach (string a in a2)
            {
                // get the specific the node and the value
                XmlNodeList nodeList = doc.GetElementsByTagName(a);
                string txt = " ";
                if (nodeList.Count > 0)
                {
                    for (int i = 0; i < nodeList.Count; i++)
                    {
                        txt += (i == 0 ? string.Empty : ",") + nodeList[i].InnerText;
                    }

                }

                //out put the txt value
                txt = "Console output: " + txt;
                Console.WriteLine(txt);

                // write the serach result value into the output file
                using (StreamWriter sw = new StreamWriter(outFile, true, Encoding.UTF8))
                {
                    sw.WriteLine(txt);
                }

            }
        }

        /// <summary>
        /// This is will trigger when project start looping
        /// </summary>
        /// <returns></returns>
        private string[] InputEntrys()
        {
            string[] entrys = { };
            bool loop = true;
            while (loop)
            {
                Console.Write("Console input:");
                string entryStr = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entryStr))
                {
                    entrys = entryStr.Split(' ');
                    if (entrys.Length > 0)
                    {
                        loop = false;
                    }
                }
                else
                {
                    Console.WriteLine("Input nothing.Please input again.");
                }
            }
            return entrys;
        }
    }
}
