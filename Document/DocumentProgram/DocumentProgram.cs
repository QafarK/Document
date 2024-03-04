using Document.IDocument;

namespace Document.DocumentProgram;
/* 1. DocumentProgram adinda bir class yaradin hansi ki icinde uc metod var:
   
   	- OpenDocument 
   	- EditDocument (virtual)
   	- SaveDocument (virtual)
   
   	Her uc metod voiddir ve ekrana acagidakilari cixardirlar.
   	
   	1. Document Opened
   	2. Can Edit in Pro and Expert versions
   	3. Can Save in Pro and Expert versions
   */
using IDocument;
class DocumentProgram : IDocument
{
    public virtual void OpenDocument() => Console.WriteLine("Document Opened");

    public virtual void EditDocument() => Console.WriteLine("Can Edit in Pro and Expert versions");

    public virtual void SaveDocument() => Console.WriteLine("Can Save in Pro and Expert versions");

}
