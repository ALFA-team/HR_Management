using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Management.Models
{
    public class QuizzesModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastAccessDate { get; set; }
        public string Result { get; set; }

    }
}