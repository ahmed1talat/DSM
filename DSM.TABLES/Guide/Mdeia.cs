using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.TABLES.Base;
using static DSM.COMMON.General.Enums;

namespace DSM.TABLES.Guide
{
    public class Mdeia:BaseEntity
    {
        public string path { get; set; }
        public mediaType mediaType { get; set; }

        public ICollection<ScreenImage> screenImages { get; set; }

    }

    public class MaimGroup : BaseEntity
    {
        public string Name { get; set; }
       

    }

    public class ScreenGroup : BaseEntity
    {
        public Guid ScreenId { get; set; }

        public Guid GroupId { get; set; }
    }
}
