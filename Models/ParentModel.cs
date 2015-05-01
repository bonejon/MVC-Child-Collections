using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildBinding.Models
{
    public class ParentModel
    {
        public ParentModel()
            : base()
        {
            this.ChildModels = new List<ChildModel>();
        }

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public IEnumerable<ChildModel> ChildModels
        {
            get;
            set;
        }
    }
}