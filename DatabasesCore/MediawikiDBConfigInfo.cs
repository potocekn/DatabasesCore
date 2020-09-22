using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesCore
{
    class MediawikiDBConfigInfo : ConfigInfo
    {
        public string MwPageTable { get; set; }
        public string MwTextTable { get; set; }

    }
}
