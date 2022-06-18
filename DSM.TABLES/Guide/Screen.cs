using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.TABLES.Base;
using static DSM.COMMON.General.Enums;

namespace DSM.TABLES.Guide
{
    public class ImagesScreen:BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Notes { get; set; }
        public bool IsOnline { get; set; }
        public DateTime LastOnlineDate { get; set; }
        public float ScreenSize  { get; set; }
        public ScreenDirection ScreenDirection { get; set; }
        [ForeignKey("Branch")]
        public Guid BranchId { get; set; }

        public Branch Branch { get; set; }

        public ICollection<ScreenImage> screenImages { get; set; }

    }
    public class ScreenImage :BaseEntity
    {
        public int Duration { get; set; }
        public Animation  Animation{ get; set; }
        public ScheduledAttribution scheduledAttribution { get; set; }
        [ForeignKey("screen")]
        public int screenId { get; set; }

        public virtual ImagesScreen screen{ get; set; }
        [ForeignKey("mdeia")]
        public Guid mdeiaId { get; set; }

        public virtual Mdeia mdeia { get; set; }

    }

    public class ImageDetails: BaseEntity
    {
        public string title { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }


    }

}
