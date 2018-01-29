using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoFilters = new PhotoFilters();
            var photoProcessor = new PhotoProcessor();
            PhotoProcessor.PhotoProcessorHandler filterHandler = photoFilters.ApplyBrightness;
            filterHandler += photoFilters.Resize;
            filterHandler += photoFilters.ApplyContrast;
            filterHandler += RemoveRedEyes;
            photoProcessor.Process("photo.jpg", filterHandler);

            Console.WriteLine();
            Action<Photo> filterHandlerAction = photoFilters.ApplyBrightness;
            filterHandlerAction += photoFilters.Resize;
            filterHandlerAction += photoFilters.ApplyContrast;
            filterHandlerAction += RemoveRedEyes;
            photoProcessor.Process("photo2.jpg", filterHandlerAction);


        }
        static void RemoveRedEyes(Photo photo)
        {
            Console.WriteLine("RemoveRedEyes");
        }
    }
}
