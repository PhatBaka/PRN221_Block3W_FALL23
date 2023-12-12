using DataAccessObjects;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ImageDAO dao;

        public ImageRepository()
        {
            dao = new ImageDAO();
        }

        public Guid SaveImageToDatabase(string imagePath) => dao.SaveImageToDatabase(imagePath);
        public MemoryStream DisplayImageFromDatabase(int imageID) => dao.DisplayImageFromDatabase(imageID);
    }
}
