using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoProcessorHandler(Photo photo);
        public void Process(string path, PhotoProcessorHandler filterHandler)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            filterHandler(photo);
            photo.Save();
        }

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            filterHandler(photo);
            photo.Save();
        }
    }
}
