using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DocumentWorker dw;
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();

            if (key=="pro")
                dw = new ProDocumentWorker();
            else if (key=="exp")
                dw = new ExpertDocumentWorker();
            else
                dw = new DocumentWorker();

            dw.OpenDocument();
            dw.EditDocument();
            dw.SaveDocument();
            Console.ReadLine();
        }
    }
}
