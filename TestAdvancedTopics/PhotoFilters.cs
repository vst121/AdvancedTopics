using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdvancedTopics
{
    public class PhotoFilters
    {
        internal void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying Brighness to Photo ... ");
        }

        internal void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying Contrast to Photo  ... ");

        }

        internal void ApplyResize(Photo photo)
        {
            Console.WriteLine("Applying Resize to Photo  ... ");
        }
    }
}
