using System;

namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        public string Path{get; set;}
        public FilterSave(string path)
        {
            this.Path = path;
        }
        public IPicture Filter(IPicture image)
        {
            PictureProvider foto = new PictureProvider();
            foto.SavePicture(image, this.Path);
            return image;
        }
    }
}