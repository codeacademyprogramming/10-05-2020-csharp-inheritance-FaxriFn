using System;

namespace HomeWork5102020
{
    class ProDocumentProgram :DocumentProgram
    {
   
        public sealed override void EditDocument()
        {
            Console.WriteLine("Document Edited (burda override elediyiniz metodu seald edirsiniz)");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Edited (burda override elediyiniz metodu seald edirsiniz) ");
        }
    }
}
