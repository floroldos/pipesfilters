using System;
using CognitiveCoreUCU;

namespace CompAndDel.Pipes
{
    public class FilterCondicional : IFilter
    {
        public string Path{get; set;}
        public FilterCondicional(string path)
        {
            this.Path = path;
        }
        public IPicture Send(IPicture picture)
        {
            this.image = picture;
            return this.image;
        }
        static void FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
            }
            else
                Console.WriteLine("No Face Found");
        }

    }
}
