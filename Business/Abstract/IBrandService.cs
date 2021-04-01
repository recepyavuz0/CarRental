using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Delete(Brand car);
        IResult Update(Brand car);

        IDataResult<List<Brand>> GetAll();

        
    }
}
