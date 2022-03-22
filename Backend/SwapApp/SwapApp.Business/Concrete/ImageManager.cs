using SwapApp.Business.Abstract;
using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Concrete
{
    public class ImageManager : IImageService
    {
        private IImageRepository _imageRepository;

        public ImageManager(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public void Create(Image entity)
        {
            _imageRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _imageRepository.Delete(id);
        }

        public List<Image> GetAll()
        {
            return _imageRepository.GetAll();
        }

        public Image GetById(int id)
        {
            return _imageRepository.GetById(id);
        }

        public void Update(Image entity)
        {
            _imageRepository.Update(entity);
        }
    }
}
