//Strategy pattern : Best suited in cases where multiple if else or a switch statement to handle some block of code. 



using design_patterns.Strategy;

//Image storage using JPEG Compression and BlackWhite Filter
var imageStorage = new ImageStorage(new JpegCompressor(),
                   new BlackAndWhiteFilter());
imageStorage.StoreImage("First Image");

//Result from console

//Using the Jpeg Compressor to compress First Image
//Using black and while filter on First Image

//Image Storage using 
var secondImageStorage = new ImageStorage(new PngCompressor(),
                          new HighContrastFilter());
secondImageStorage.StoreImage("Second Image");

//Result from console

//Using PNG Compressor to compress Second Image
//Using the High Contrast filter on Second Image
