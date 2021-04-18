using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuestRoomPractic.Models
{
    public class QuestRoomInitializer : DropCreateDatabaseAlways<QuestRoomContext>
    {
        protected override void Seed(QuestRoomContext context)
        {

            var room = new List<QuestRoom>
            {
                new QuestRoom(){ Name = "CURSED CASTLE",
                    Description = "You all are loyal knights of a benevolent kingdom returning from " +
                    "a faraway journey. As you approach your town, you see dark, ominous clouds. You " +
                    "arrive to find your castle eerily dark, quiet and sealed shut. Local villagers " +
                    "have told you that no one has been seen going in or out for days. Recognizing the" +
                    " classic signs of an evil curse, you decide it is your duty to do whatever you can to" +
                    " lift it, but you won’t be able to survive inside the curse for more than an hour so – Good luck!",

                    PassingTime = "60mins",
                    MaxCountOfPlayer = 12,
                    MinCountOfPlayer = 3,
                    MinAge = 7,
                    Difficaltly = 2,
                    EscapeRate = 6,
                    Telephone = "+12455666",
                    CompanyName = "Diggy company",
                    Rating = (float)3.5,
                    Address = "St. Louis, MO 63102",
                    MainImage = "https://worldofescapes-com.s3.amazonaws.com/uploads/quests/9620/medium/mountain-time-escape-rooms-paranormal-mystery.jpg",
                    //ImagesGallery = { "https://escapequest.com.ua/Upload/0efe5f54-3135-4908-9c83-d3e82c875006.jpg", "https://questroom.com.ua/dist/pict_rooms/thumbs/yzFP4TOi.png" }
                },

                 new QuestRoom(){ Name = "SECRET SOCIETY",
                    Description = "You all are loyal knights of a benevolent kingdom returning from " +
                    "a faraway journey. As you approach your town, you see dark, ominous clouds. You " +
                    "arrive to find your castle eerily dark, quiet and sealed shut. Local villagers " +
                    "have told you that no one has been seen going in or out for days. Recognizing the" +
                    " classic signs of an evil curse, you decide it is your duty to do whatever you can to" +
                    " lift it, but you won’t be able to survive inside the curse for more than an hour so – Good luck!",
                    PassingTime = "150mins.",
                    MaxCountOfPlayer = 9,
                    MinCountOfPlayer = 4,
                    MinAge = 10,
                    Difficaltly = 4,
                    EscapeRate = 7,
                    Telephone = "+12455666",
                    CompanyName = "Abs3 company",
                    Rating = (float)4.5,
                    Address = "St. Elena, MO 63102",
                    MainImage = "https://f.kyivmaps.com/location/3224/3rsR9.jpg",
                    //ImagesGallery = { "https://questroom.com.ua/dist/pict_rooms/thumbs/yzFP4TOi.png", "https://escapequest.com.ua/Upload/0efe5f54-3135-4908-9c83-d3e82c875006.jpg"}
                },

                  new QuestRoom(){ Name = "DAVINCI’S WORKSHOP",
                    Description = "You all are loyal knights of a benevolent kingdom returning from " +
                    "a faraway journey. As you approach your town, you see dark, ominous clouds. You " +
                    "arrive to find your castle eerily dark, quiet and sealed shut. Local villagers " +
                    "have told you that no one has been seen going in or out for days. Recognizing the" +
                    " classic signs of an evil curse, you decide it is your duty to do whatever you can to" +
                    " lift it, but you won’t be able to survive inside the curse for more than an hour so – Good luck!",
                    PassingTime = "120mins.",
                   MaxCountOfPlayer = 5,
                    MinCountOfPlayer = 1,
                    MinAge = 15,
                    Difficaltly = 3,
                    EscapeRate = 9,
                    Telephone = "+12455666",
                    CompanyName = "Abs company",
                    Rating = (float)2.5,
                    Address = "St. Louis, MO 63102",
                    MainImage = "https://f.kyivmaps.com/location/3204/VDvzc.jpg",
                      //ImagesGallery = { "https://questroom.com.ua/dist/pict_rooms/thumbs/yzFP4TOi.png", "https://escapequest.com.ua/Upload/0efe5f54-3135-4908-9c83-d3e82c875006.jpg"}
                  },
                    new QuestRoom(){ Name = "DAVINCI’S WORKSHOP",
                    Description = "You all are loyal knights of a benevolent kingdom returning from " +
                    "a faraway journey. As you approach your town, you see dark, ominous clouds. You " +
                    "arrive to find your castle eerily dark, quiet and sealed shut. Local villagers " +
                    "have told you that no one has been seen going in or out for days. Recognizing the" +
                    " classic signs of an evil curse, you decide it is your duty to do whatever you can to" +
                    " lift it, but you won’t be able to survive inside the curse for more than an hour so – Good luck!",
                    PassingTime = "120mins.",
                   MaxCountOfPlayer = 5,
                    MinCountOfPlayer = 1,
                    MinAge = 15,
                    Difficaltly = 3,
                    EscapeRate = 9,
                    Telephone = "+12455666",
                    CompanyName = "Abs company",
                    Rating = (float)2.5,
                    Address = "St. Louis, MO 63102",
                    MainImage = "https://f.kyivmaps.com/location/3207/mGevK.jpg",
                    //ImagesGallery = { "https://questroom.com.ua/dist/pict_rooms/thumbs/yzFP4TOi.png", "https://escapequest.com.ua/Upload/0efe5f54-3135-4908-9c83-d3e82c875006.jpg"}

                },
                     new QuestRoom(){ Name = "DAVINCI’S WORKSHOP",
                    Description = "You all are loyal knights of a benevolent kingdom returning from " +
                    "a faraway journey. As you approach your town, you see dark, ominous clouds. You " +
                    "arrive to find your castle eerily dark, quiet and sealed shut. Local villagers " +
                    "have told you that no one has been seen going in or out for days. Recognizing the" +
                    " classic signs of an evil curse, you decide it is your duty to do whatever you can to" +
                    " lift it, but you won’t be able to survive inside the curse for more than an hour so – Good luck!",
                    PassingTime = "120mins.",
                   MaxCountOfPlayer = 5,
                    MinCountOfPlayer = 1,
                    MinAge = 15,
                    Difficaltly = 3,
                    EscapeRate = 3,
                    Telephone = "+12455666",
                    CompanyName = "Abs company",
                    Rating = (float)2.5,
                    Address = "St. Louis, MO 63102",
                    MainImage = "https://i.pinimg.com/originals/f9/fd/16/f9fd167c1c0e421996a2390e0da9ddab.jpg",
                    //ImagesGallery = { "https://questroom.com.ua/dist/pict_rooms/thumbs/yzFP4TOi.png", "https://escapequest.com.ua/Upload/0efe5f54-3135-4908-9c83-d3e82c875006.jpg"}

                },
                       new QuestRoom(){ Name = "DAVINCI’S WORKSHOP",
                    Description = "You all are loyal knights of a benevolent kingdom returning from " +
                    "a faraway journey. As you approach your town, you see dark, ominous clouds. You " +
                    "arrive to find your castle eerily dark, quiet and sealed shut. Local villagers " +
                    "have told you that no one has been seen going in or out for days. Recognizing the" +
                    " classic signs of an evil curse, you decide it is your duty to do whatever you can to" +
                    " lift it, but you won’t be able to survive inside the curse for more than an hour so – Good luck!",
                    PassingTime = "120mins.",
                   MaxCountOfPlayer = 5,
                    MinCountOfPlayer = 1,
                    MinAge = 15,
                    Difficaltly = 3,
                    EscapeRate = 8,
                    Telephone = "+12455666",
                    CompanyName = "Abs company",
                    Rating = (float)2.5,
                    Address = "St. Louis, MO 63102",
                    MainImage = "https://media-cdn.tripadvisor.com/media/photo-s/07/6e/95/86/quest-room.jpg",
                    //ImagesGallery = { "https://questroom.com.ua/dist/pict_rooms/thumbs/yzFP4TOi.png", "https://escapequest.com.ua/Upload/0efe5f54-3135-4908-9c83-d3e82c875006.jpg"}

                }

            };

            var gallary = new List<GallaryQuestRoom>
            {
                new GallaryQuestRoom()
                {
                    Image = "https://escapequest.com.ua/Upload/0efe5f54-3135-4908-9c83-d3e82c875006.jpg",
                    QuestRoom = room[0],
                },
                new GallaryQuestRoom()
                {
                    Image = "https://questroom.com.ua/dist/pict_rooms/rp1c8OYR.jpg",
                    QuestRoom = room[0],
                },
                 new GallaryQuestRoom()
                {
                    Image = "https://locky.com.ua/assets/cache_image/uploads/675x_1280x_1280x_1280x_dikiy_zapad_683x427_62d.jpg",
                    QuestRoom = room[0],
                },

                new GallaryQuestRoom()
                {
                    Image = "https://f.kyivmaps.com/location/3195/VXRwS.jpg",
                    QuestRoom = room[1],
                },
                 new GallaryQuestRoom()
                {
                    Image = "https://f.kyivmaps.com/location/3204/VDvzc.jpg",
                    QuestRoom = room[1],
                },


                 new GallaryQuestRoom()
                {
                    Image = "https://f.kyivmaps.com/location/3207/mGevK.jpg",
                    QuestRoom = room[2],
                },
                 new GallaryQuestRoom()
                {
                    Image = "https://f.kyivmaps.com/location/3224/3rsR9.jpg",
                    QuestRoom = room[2],
                }
            };

            context.QuestRooms.AddRange(room);
            context.GallaryQuestRooms.AddRange(gallary);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}