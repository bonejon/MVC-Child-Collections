using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildBinding.Models
{
    public class ChildModel
    {
        public int ChildId
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string SomeOtherProperty
        {
            get;
            set;
        }
    }
}