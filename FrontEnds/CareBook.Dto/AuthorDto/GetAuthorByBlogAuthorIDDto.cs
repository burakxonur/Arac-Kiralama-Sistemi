﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Dto.AuthorDto
{
    public class GetAuthorByBlogAuthorIDDto
    {
        public int BlogID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
        public int AuthorID { get; set; }
    }
}
