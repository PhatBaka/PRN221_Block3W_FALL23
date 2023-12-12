using BusinessObjects.Helpers;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ImageDAO
    {
        private readonly FlowerShopContext _context;

        public ImageDAO()
        {
            _context = new FlowerShopContext();
        }

        public Guid SaveImageToDatabase(string imagePath)
        {
            try
            {
                byte[] imageData;
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                }

                using (var dbContext = new FlowerShopContext())
                {
                    var imageEntity = new Image { Data = imageData };
                    dbContext.Images.Add(imageEntity);
                    dbContext.SaveChanges();
                    return imageEntity.Id;
                }
            }
            catch (Exception ex)
            {
                LoggerService.Logger(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public MemoryStream DisplayImageFromDatabase(int imageID)
        {
            try
            {
                using (var dbContext = new FlowerShopContext())
                {
                    var imageEntity = dbContext.Images.Find(imageID);
                    if (imageEntity != null)
                    {
                        byte[] imageData = imageEntity.Data;
                        MemoryStream stream = new MemoryStream(imageData);
                        return stream;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                LoggerService.Logger(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
