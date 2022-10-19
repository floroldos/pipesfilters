using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");

            PipeNull first = new PipeNull();
            FilterSave guardar2 = new FilterSave("guardado2.jpg");
            PipeSerial fifth = new PipeSerial(guardar2, first);
            FilterNegative negativo = new FilterNegative();
            PipeSerial second = new PipeSerial(negativo, fifth);
            FilterSave guardar = new FilterSave("guardado1.jpg");
            PipeSerial third = new PipeSerial(guardar, second);
            FilterGreyscale grises = new FilterGreyscale();
            PipeSerial fourth = new PipeSerial(grises, third);
            fourth.Send(picture);

        }
    }
}
