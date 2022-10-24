using System;
using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterTwitter : IFilter
    {
        public string Path{get; set;}
        public FilterTwitter(string path)
        {
            this.Path = path;
        }
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("Try", this.Path));
            return image;
        }
    }
}