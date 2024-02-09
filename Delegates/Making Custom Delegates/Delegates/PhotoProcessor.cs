using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo); // Here we are creating the delegate
                                                             //PhotoFilterHandler whose only job is to
                                                             //point to the different methods of PhotoFilter class
                                                             //When deifining Delegate we need to define the signature
                                                             //of the method which we want to point to.


        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);   //with these we dont know what kind of filter is being applied
                                    //we are just calling the delegate and the delegate is pointing to the
                                    //method which we want to call. 

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


