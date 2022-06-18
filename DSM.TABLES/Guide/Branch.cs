using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.TABLES.Base;
using DSM.TABLES.Pepole;

namespace DSM.TABLES.Guide
{
    public class Branch:BaseEntity
    {
        public string Name { get; set; }
        public string Poster { get; set; }
        public ICollection<ImagesScreen> screens { get; set; }
        public ICollection<UserBranch> userBranches { get; set; }


    }
}
