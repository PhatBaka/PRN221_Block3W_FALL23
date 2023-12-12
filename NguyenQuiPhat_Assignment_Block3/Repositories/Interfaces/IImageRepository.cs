using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IImageRepository
    {
        public Guid SaveImageToDatabase(string imagePath);
        public MemoryStream DisplayImageFromDatabase(int imageID);
    }
}
