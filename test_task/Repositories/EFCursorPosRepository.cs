using Microsoft.EntityFrameworkCore;
using test_task.Models;

namespace test_task.Repositories
{
    public class EFCursorPosRepository : DbContext
    {

        public EFCursorPosRepository(DbContextOptions options)
        : base(options)
        {
        }
       
        public DbSet<CursorPos>? cursorPosSet { get; set; }

        public EFCursorPosRepository() { }

        public void AddCursorPos(CursorPos cursorPos) 
        {
            if(cursorPos != null)
            {
                cursorPosSet.Add(cursorPos);
            }
        }
    }
}
