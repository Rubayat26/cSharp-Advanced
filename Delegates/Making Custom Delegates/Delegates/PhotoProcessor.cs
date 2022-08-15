using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo); //here we are creating the delegate

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);   // we are calling the delegate and passing the input 

            photo.Save();
        }
    } 
}





// the idea is we will create a delegate whos only job would be to point to the
//method which we want. Like here we create a delegate PhotoFilterHandler whose only job is to 
//point to the Photofilters different methods

//Here the delegate PhotoFilterHandler points to the different methods of PhotoFilter like 
//ApplyBrightness, ApplyContrast. And in those methods the structure is to pass in Photo as a 
//parameter. So the delegate has to be designed in that way 


