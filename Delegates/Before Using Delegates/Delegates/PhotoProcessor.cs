using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var photoFilter = new PhotoFilters();
            photoFilter.ApplyBrightness(photo);
            photoFilter.ApplyContrast(photo);
            photoFilter.Resize(photo);

            photo.Save();
        }
    }
} 