namespace Document.ExpertDocument;
/*3. ExpertDocument adinda bir class yaradin hansi ki ProDocumentProgram classindan miras alir ve ekrana asagidakilari cixardir:

	1. Document Opened
	2. Document Edited
	3. Document Saved in pdf format
*/
using IDocument;
using ProDocumentProgram;
class ExpertDocument : ProDocumentProgram, IDocument
{

    public override sealed void OpenDocument() => Console.WriteLine("Document Opened");
    public override sealed void EditDocument() => Console.WriteLine("Document Edited");
    public override sealed void SaveDocument() => Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");

}
