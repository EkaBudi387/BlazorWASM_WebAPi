﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASM_WebAPi.Shared
{
    public class RecordDetails
    {

        [Key]

        public int No { get; set; }

        public DateTime DateIn { get; set; }

        public string SA_SN { get; set; }

        public string SA_PN { get; set; }

    }
}
