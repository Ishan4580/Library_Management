using Library_Book_Manager.models;
using Microsoft.EntityFrameworkCore;



namespace Library_Book_Manager.DataBase
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Book_Borrowing> Book_Borrowing { get; set; }
        public DbSet<Lib_Person> lib_People { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;" +
                "port=3309;" +
                "database=LibraryDb;" +
                "user=root;" +
                "password=ishan123";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
