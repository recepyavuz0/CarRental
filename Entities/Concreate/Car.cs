using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concreate
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public short DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
