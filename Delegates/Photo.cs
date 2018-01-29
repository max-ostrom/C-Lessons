using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Photo
    {
        private Photo(string path)
        {
            _path = path;
        }
        private string _path;
        public static Photo Load(string path)
        {
            return new Photo(path);
        }
        public void Save()
        {

        }
    }
}
