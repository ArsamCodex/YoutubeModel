using Microsoft.EntityFrameworkCore;

namespace YoutubeModel.Data
{
    public class AplcationDbContext :DbContext
    {


        public AplcationDbContext(DbContextOptions<AplcationDbContext> options)
            : base(options)
        {


        }

        public DbSet<Model.Employee> Employee { get; set; } = default!;
    }
}
