using System;


namespace HunterApi.Models
{
    public class Collect
    {
        public int CollectId { get; set; }

        //postId��userId�������
        public int PostId { get; set; }

        public int UserId { get; set; }

        public DateTime Time { get; set; }

        public Collect()
        {
        }
    }
   
}
