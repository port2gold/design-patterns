//Visitor Design Pattern //Design that helps with Extension


using design_patterns.Visitor;

var document = new HtmlDocument();
document.Add(new HeadingNode());
document.Add(new AnchorNode());
document.Execute(new HighlightOperation());

//Console Result 
//Highlight - Heading
//Highligth - Anchor


document.Execute(new PlainTextOperation());

//Console Result 
//Plaintext - Heading
//Plaintext - Anchor

