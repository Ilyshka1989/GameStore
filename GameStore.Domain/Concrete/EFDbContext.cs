using GameStore.Domain.Entities;
using System.Data.Entity;
//доступ к базе данных 

namespace GameStore.Domain.Concrete
{
    public class EFDbContext: DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
