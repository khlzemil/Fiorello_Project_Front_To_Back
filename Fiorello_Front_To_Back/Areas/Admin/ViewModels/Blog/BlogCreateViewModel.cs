﻿namespace Fiorello_Front_To_Back.Areas.Admin.ViewModels.Blog
{
    public class BlogCreateViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }

        public IFormFile MainPhoto { get; set; }
    }
}
