﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        public int HeadingID { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        //Category-Heading İlişkisi
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //Heading -Content İlişkisi
        public ICollection<Content> Contents { get; set; }

        //Yazar -Başlık İlişkisi
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
