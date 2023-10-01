namespace design_patterns.Builder
{
    public class PdfDocumentBuilder : PresentationBuilder
    {
        PdfDocument pdfDocument = new PdfDocument();
        public void AddSlide(Slide slide)
        {
            pdfDocument.AddPage(slide.GetText());
        }

        public PdfDocument GetPdfDocument()
        {
            return pdfDocument;
        }
    }
}
