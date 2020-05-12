using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5102020
{
    class Program
    {
        static void Main(string[] args)
        {

            GetInput();

            Console.ReadKey();
        }

        static void GetInput()
        {
            Console.WriteLine("Enter Keyword");
            string key = Console.ReadLine();
            ChangeKey(key);
        }
        static void ChangeKey(string key)
        {
            DocumentProgram documentProgram;


            switch (key)
            {
                case "basic":
                    documentProgram = new DocumentProgram();

                    break;
                case "pro":
                    documentProgram = new ProDocumentProgram();

                    break;
                case "expert ":
                    documentProgram = new ExpertDocument();

                    break;
                default:
                    throw new ArgumentException("Keyword is not valid");
               


            }
            ShowFull(documentProgram);

        }
      
        static void ShowFull(DocumentProgram documentProgram)
        {
            documentProgram.OpenDocument();
            documentProgram.EditDocument();
            documentProgram.SaveDocument();
        }
    }
}
