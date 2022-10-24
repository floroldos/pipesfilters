using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using TwitterUCU;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");

            FilterTwitter twittear2 = new FilterTwitter("guardado2.jpg");
            FilterNegative negativo = new FilterNegative();
            FilterSave guardado2 = new FilterSave("guardado2.jpg");
            FilterTwitter twittear1 = new FilterTwitter("guardado1.jpg");
            FilterGreyscale grises = new FilterGreyscale();
            FilterSave guardado1 = new FilterSave("guardado1.jpg");


            PipeNull first = new PipeNull();
            PipeSerial tuit2 = new PipeSerial(twittear2, first);
            PipeSerial guardar2 = new PipeSerial(guardado2, tuit2);
            PipeSerial negative = new PipeSerial(negativo, guardar2);
            PipeSerial tuit = new PipeSerial(twittear1, negative);
            PipeSerial guardar = new PipeSerial(guardado1, tuit);
            PipeSerial greyscale = new PipeSerial(grises, guardar);
            
            greyscale.Send(picture);

        }
    }
}
