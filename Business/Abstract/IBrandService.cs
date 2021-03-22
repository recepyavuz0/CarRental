using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Delete(Brand car);
        void Update(Brand car);

        List<Brand> GetAll();
        
    }
}
