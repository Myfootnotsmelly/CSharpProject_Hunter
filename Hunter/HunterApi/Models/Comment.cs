using System;


namespace HunterApi.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        //postId��userId�������
        public int PostId { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string CommentContext { get; set; }

        public DateTime Time { get; set; }

        public Comment()
        {
        }
    }
}
