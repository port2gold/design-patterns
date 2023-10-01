//Builder Design Pattern
//To seperate the construction of an object from its representation


using design_patterns.Builder;

var presentation = new Presentation();
presentation.AddSlide(new Slide("Slide 1"));
presentation.AddSlide(new Slide("Slide 2"));

var builder = new PdfDocumentBuilder();
presentation.Export(builder);
var pdf = builder.GetPdfDocument();

//Console Result 

//Adding a page to PDF
//Adding a page to PDF
//Adding a page to PDF


var movieBuilder = new MovieBuilder();
presentation.Export(movieBuilder);
var movie = movieBuilder.GetMovie();

//Console Result

//Adding a frame to Movie
//Adding a frame to Movie
//Adding a frame to Movie
