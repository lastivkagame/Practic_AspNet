using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuestRoomPractic.Models
{
    public class QuestRoom
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string PassingTime { get; set; }

        public int MaxCountOfPlayer { get; set; }
        public int MinCountOfPlayer { get; set; }

        public int MinAge { get; set; }

        public int Difficaltly { get; set; }

        public int EscapeRate { get; set; }

        [Required]
        public string Telephone { get; set; }

        public string CompanyName { get; set; }
        public float Rating { get; set; }

        [Required]
        public string Address { get; set; }

        public string MainImage { get; set; }

        [NotMapped]
        public string FullIdentity => "Element" + this.Id;

        virtual public ICollection<GallaryQuestRoom> ImagesGallery { get; set; }


        public QuestRoom()
        {
            ImagesGallery = new List<GallaryQuestRoom>();
        }
    }
}