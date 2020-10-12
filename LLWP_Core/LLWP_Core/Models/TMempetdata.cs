﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LLWP_Core.Models
{
    public partial class TMempetdata
    {
        public int FPeId { get; set; }
        public string FPeMem { get; set; }
        public string FPeMemNumber { get; set; }
        public string FPeVarity { get; set; }
        public string FPeAge { get; set; }
        public double? FPeWeight { get; set; }
        public string FPeBirth { get; set; }
        public string FPeSex { get; set; }
        public string FPeVac { get; set; }
        public string FPeFix { get; set; }

        [DisplayName("會員寵物編號")]
        public string FPeNumber { get; set; }
        public string FPePhoto { get; set; }
    }
}
