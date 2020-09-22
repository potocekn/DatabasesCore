﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesCore
{
    class MwTextData
    {
        public int Id { get; set; }
        public byte[] Text { get; set; }

        public MwTextData() { }
        public MwTextData(int id, byte[] text)
        {
            this.Id = id;
            this.Text = text;
        }
    }
}
