using System;

namespace HomeWork5102020
{
    class DocumentProgram
    {
    
   


    public virtual void OpenDocument()
        {
            Console.WriteLine("Document Opened (DocumentProgram)");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions (DocumentProgram)");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions (DocumentProgram)");
        }
    }
}
