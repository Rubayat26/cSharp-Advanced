using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);   // we are calling the delegate and passing the input 

            photo.Save();
        }
    } 
} 