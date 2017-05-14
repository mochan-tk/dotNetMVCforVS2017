using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Comment
    {
        public int Id { get; set; }           // プライマリキー
        public string UserName { get; set; }  // 投稿ユーザ名
        public string Body { get; set; }      // 本文
        public DateTime Created { get; set; } // 投稿日時
    }
}