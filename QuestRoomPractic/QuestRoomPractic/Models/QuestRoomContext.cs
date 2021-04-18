using System;
using System.Data.Entity;
using System.Linq;

namespace QuestRoomPractic.Models
{
    public class QuestRoomContext : DbContext
    {
        // Your context has been configured to use a 'QuestRoomContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QuestRoomPractic.Models.QuestRoomContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QuestRoomContext' 
        // connection string in the application configuration file.
        public QuestRoomContext()
            : base("name=QuestRoomContext1")
        {
            Database.SetInitializer(new QuestRoomInitializer());
        }

        public DbSet<QuestRoom> QuestRooms { get; set; }
        public DbSet<GallaryQuestRoom> GallaryQuestRooms { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}