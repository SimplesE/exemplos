﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplesE.Model.Core {
    public class User {

        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Create { get; set; }
        public Address Address { get; set; }
    }
}
