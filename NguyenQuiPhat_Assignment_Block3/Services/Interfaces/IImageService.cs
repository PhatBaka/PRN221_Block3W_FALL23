using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IImageService
    {
        public Guid SaveImageToDatabase(string imagePath);
        public MemoryStream DisplayImageFromDatabase(int imageID);
    }
}
