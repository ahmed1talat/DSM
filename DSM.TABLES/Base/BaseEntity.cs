using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.TABLES.Pepole;

namespace DSM.TABLES.Base
{
    public class BaseEntity
    {
        #region prop
        [Key]
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        [ForeignKey("userModifided")]
        public Guid ModifiedBy { get; set; }
        [ForeignKey("userDeleteed")]
        public Guid DeletedBY { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        [ForeignKey("userCreated")]
        public Guid AddedBy { get; set; }
        public User userCreated { get; set; }
        public User userModifided { get; set; }
        public User userDeleteed { get; set; }

        public DateTime DeletedDate{ get; set; }

        #endregion







    }
}
