using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.NewFolder4.NewFolder;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        //Construnctor:
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }
        //Añadir DBSets (Tablas de la base de datos)
        public DbSet<User>? Users { get; set; }
    }
}
