using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerialNo
{
    class Program
    {
        static void Main(string[] args)
        {
            var copyFrom = @"C:\Users\saito\Pictures\数\default.jpg";
            var copyTo = @"C:\Users\saito\Pictures\数\copy.jpg";
            var root = @"C:\Users\saito\Pictures\数\";
            File.Copy(copyFrom, copyTo, true);
            for (var i = 81; i < 150;i++ )
                File.Copy(copyTo, root + "0" + i.ToString() + ".jpg", true);
        }
    }
}
