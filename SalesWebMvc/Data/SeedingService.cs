using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

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
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000, d1);
            Seller s2= new Seller(2, "Fabio Carvalho", "fabio@gmail.com", new DateTime(1988, 6, 23), 1300, d2);
            Seller s3= new Seller(3, "Ana Abreu", "ana@gmail.com", new DateTime(1978, 5, 20), 1200, d1);
            Seller s4= new Seller(4, "Miguel Simoes", "miguel@gmail.com", new DateTime(1998, 4, 2), 1000, d2);
            Seller s5= new Seller(5, "Filipe Nunes", "filipe@gmail.com", new DateTime(1988, 6, 12), 1100, d3);
            Seller s6= new Seller(6, "Carolina Lourenço", "carolina@gmail.com", new DateTime(1978, 5, 17), 900, d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2020, 1, 1), 200, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2020, 1, 21), 1200, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2020, 1, 2), 230, SaleStatus.Billed, s4);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2020, 1, 10), 500, SaleStatus.Billed, s6);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2020, 1, 11), 700, SaleStatus.Billed, s3);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2020, 1, 13), 800, SaleStatus.Billed, s1);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2020, 1, 20), 100, SaleStatus.Billed, s3);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2020, 1, 3), 240, SaleStatus.Billed, s4);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2020, 1, 5), 600, SaleStatus.Billed, s5);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2020, 2, 25), 2200, SaleStatus.Billed, s2);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2020, 2, 7), 300, SaleStatus.Billed, s3);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2020, 2, 12), 2300, SaleStatus.Billed, s2);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2020, 2, 15), 530, SaleStatus.Billed, s5);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2020, 2, 1), 350, SaleStatus.Billed, s3);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2020, 2, 2), 200, SaleStatus.Billed, s4);


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13, sr14, sr15);

            _context.SaveChanges();
        }
    }
}
