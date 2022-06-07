using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {

        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public void Seed()
        {
            if(_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");  
            Department d2 = new Department(1, "Eletronics");
            Department d3 = new Department(1, "Fashion");
            Department d4 = new Department(1, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000, d1);
            Seller s2= new Seller(1, "B", "bob@gmail.com", new DateTime(1998, 4, 21), 1000, d1);
            Seller s3= new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000, d1);
            Seller s4= new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000, d1);
            Seller s5= new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000, d1);
            Seller s6= new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000, d1);
        }
    }
}
