namespace FootballLeagues.Web.Areas.Admin.Models.News
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Data.Models;

    public class NewsInputModel
    {
        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        [DisplayName("Content")]
        public string Content { get; set; }

        [DisplayName("Tags")]
        public string Tags { get; set; }

        [DisplayName("Author")]
        public ApplicationUser Author { get; set; }
/*
        [DisplayName("Image")]
        public string Image { get; set; }*/
    }
}