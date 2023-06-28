﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeraclesDAO.Models
{
    public class Office : BaseModel
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Direction { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public byte CityId { get; set; }
    }
}
