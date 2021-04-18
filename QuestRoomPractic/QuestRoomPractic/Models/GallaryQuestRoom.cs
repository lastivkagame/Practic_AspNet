using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestRoomPractic.Models
{
    public class GallaryQuestRoom
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public int? QuestRoomId { get; set; }
        public QuestRoom QuestRoom { get; set; }
    }
}