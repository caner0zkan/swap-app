using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Abstract
{
    public interface IImageService
    {
        List<Image> GetAll();

        Image GetById(int id);

        void Create(Image entity);

        void Update(Image entity);

        void Delete(int id);
    }
}
