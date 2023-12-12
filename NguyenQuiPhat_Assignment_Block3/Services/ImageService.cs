using BusinessObjects.Helpers;
using Repositories;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public MemoryStream DisplayImageFromDatabase(int imageID)
        {
            try
            {
                return _imageRepository.DisplayImageFromDatabase(imageID);
            }
            catch (Exception ex)
            {
                LoggerService.Logger(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public Guid SaveImageToDatabase(string imagePath)
        {
            try
            {
                return _imageRepository.SaveImageToDatabase(imagePath);
            }
            catch (Exception ex)
            {
                LoggerService.Logger(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
