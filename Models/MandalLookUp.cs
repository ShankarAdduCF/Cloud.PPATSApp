﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Cloud.PPATSApp.Models
{
    public partial class MandalLookUp
    {
        public int Mdid { get; set; }
        public string MandalCode { get; set; }
        public string MandalName { get; set; }
        public string Accode { get; set; }
        public string IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
