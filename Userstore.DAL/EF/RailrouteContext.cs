using Railway.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.DAL.EF
{
   public class RailrouteContext : DbContext
    {
        //public RailWayContext() : base("DefaultConnection")
        //{ }
        public DbSet<Railroute> Railroutes { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<RailrouteStation> RailrouteStations { get; set; }
        static RailrouteContext()
        {
            Database.SetInitializer<RailrouteContext>(new RailrouteDbInitializer());
        }
        public RailrouteContext(string connectionString) :
            base(connectionString)
        { }
        public RailrouteContext()
        {

        }
    
    }
    public class RailrouteDbInitializer : DropCreateDatabaseIfModelChanges<RailrouteContext>
    {
        protected override void Seed(RailrouteContext db)
        {
            Station st1 = new Station
            {
                Name = "Kharkiv",
                Slug = "Something about Kharkiv",
                ArrivalDate = new DateTime(2020, 3, 17, 6, 30, 00),
                CountyDate = new DateTime(2020, 3, 17, 7, 00, 00)
            };
            Station st2 = new Station
            {
                Name = "Poltava",
                Slug = "Something about Poltava",
                ArrivalDate = new DateTime(2020, 3, 19, 23, 20, 00),
                CountyDate = new DateTime(2020, 3, 19, 23, 35, 00)
            };
            Station st3 = new Station
            {
                Name = "Kiew",
                Slug = "Something about Kiew",
                ArrivalDate = new DateTime(2020, 3, 20, 8, 40, 00),
                CountyDate = new DateTime(2020, 3, 20, 9, 00, 00)
            };
            Station st4 = new Station
            {
                Name = "Lviv",
                Slug = "Something about Lviv",
                ArrivalDate = new DateTime(2020, 3, 24, 17, 23, 00),
                CountyDate = new DateTime(2020, 3, 24, 17, 50, 00)
            };
            db.Stations.Add(st1);
            db.Stations.Add(st2);
            db.Stations.Add(st3);
            db.Stations.Add(st4);
            //Проблемы
            Railroute rl1 = new Railroute { Name = "Kharkiv - Kiew" };
            db.Railroutes.Add(rl1);
            RailrouteStation rls1 = new RailrouteStation { Railroute = rl1, Station = st2 };
            //Проблемы
            base.Seed(db);
        }
    }
}
