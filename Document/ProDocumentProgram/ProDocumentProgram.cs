namespace Document.ProDocumentProgram;
using DocumentProgram;
using IDocument;

/*2. ProDocumentProgram adinda bir class yaradin hansi ki DocumentProgram classindan miras alir ve ekrana asagidakilari cixardir:
   
   1. Document Opened
   2. Document Edited (burda override elediyiniz metodu seald edirsiniz)
   3. Document Saved in doc format, for pdf format buy Expert packet
*/
class ProDocumentProgram : DocumentProgram, IDocument
{
    public override void OpenDocument() => Console.WriteLine("Document Opened");
    public override void EditDocument() => Console.WriteLine("Document Edited");
    public override void SaveDocument() => Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");


}