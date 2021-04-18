using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuestRoomPractic.Models;

namespace QuestRoomPractic.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuestRoomContext _questRoomContext = new QuestRoomContext();

        public ActionResult Index()
        {
            //get data from DB 
            IEnumerable<QuestRoom> questRooms = _questRoomContext.QuestRooms;

            ViewBag.QuestRooms = questRooms;

            return View();
        }

        [HttpGet]
        public ActionResult ShowMoreQuestRoom(int id = 1)
        {
            ViewBag.Id = id;
            ViewBag.CurrentElement = _questRoomContext.QuestRooms.First(x => x.Id == id);

            List<GallaryQuestRoom> gallary = new List<GallaryQuestRoom>();

            foreach (var item in _questRoomContext.GallaryQuestRooms)
            {
                if(item.QuestRoomId == id)
                {
                    gallary.Add(item);
                }
            }

            if(gallary.Count == 0)
            {
                gallary.Add(new GallaryQuestRoom() { Id = -1, Image = "https://www.allianceplast.com/wp-content/uploads/2017/11/no-image.png" });
            }

            ViewBag.Gallary = gallary;

            return View();
        }
    }
}