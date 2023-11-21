using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApp.News
{
    //Este dto representa la respuesta de la Api News
    public class ArticleDto
    {
        //algunos atributos que devuelve la consulta de NewsApi
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }

    }
}
