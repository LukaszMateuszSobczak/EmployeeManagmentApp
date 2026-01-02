using EmployeeManagmentApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagmentApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasOne(e => e.Address).WithOne(a => a.Employee).HasForeignKey<Address>(a => a.EmployeeId);

            var user1 = "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f";
            var user2 = "d5a58238-5527-423b-90bd-ae0ae60a71b5";


            modelBuilder.Entity<Employee>().HasData(
        new Employee { Id = 1, FirstName = "Jan", LastName = "Nowak", Pesel = "90010100011", Email = "emp1.user1@example.com", Phone = "500001001", Position = "Developer", Salary = 8000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 2, FirstName = "Adam", LastName = "Kowalczyk", Pesel = "90010100012", Email = "emp2.user1@example.com", Phone = "500001002", Position = "Tester", Salary = 7000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 3, FirstName = "Kamil", LastName = "Zieliński", Pesel = "90010100013", Email = "emp3.user1@example.com", Phone = "500001003", Position = "Project Manager", Salary = 10500m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 4, FirstName = "Paweł", LastName = "Wójcik", Pesel = "90010100014", Email = "emp4.user1@example.com", Phone = "500001004", Position = "HR Specialist", Salary = 6500m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 5, FirstName = "Michał", LastName = "Mazur", Pesel = "90010100015", Email = "emp5.user1@example.com", Phone = "500001005", Position = "DevOps Engineer", Salary = 12000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 6, FirstName = "Tomasz", LastName = "Piotrowski", Pesel = "90010100016", Email = "emp6.user1@example.com", Phone = "500001006", Position = "Backend Developer", Salary = 9000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 7, FirstName = "Karol", LastName = "Kaczmarek", Pesel = "90010100017", Email = "emp7.user1@example.com", Phone = "500001007", Position = "Frontend Developer", Salary = 8800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 8, FirstName = "Damian", LastName = "Grabowski", Pesel = "90010100018", Email = "emp8.user1@example.com", Phone = "500001008", Position = "UX Designer", Salary = 9100m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 9, FirstName = "Konrad", LastName = "Olszewski", Pesel = "90010100019", Email = "emp9.user1@example.com", Phone = "500001009", Position = "Data Analyst", Salary = 9800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 10, FirstName = "Łukasz", LastName = "Pawlak", Pesel = "90010100020", Email = "emp10.user1@example.com", Phone = "500001010", Position = "System Administrator", Salary = 8600m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },

        new Employee { Id = 11, FirstName = "Rafał", LastName = "Duda", Pesel = "90010100021", Email = "emp11.user1@example.com", Phone = "500001011", Position = "QA Engineer", Salary = 7200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 12, FirstName = "Patryk", LastName = "Witkowski", Pesel = "90010100022", Email = "emp12.user1@example.com", Phone = "500001012", Position = "DevOps Engineer", Salary = 11800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 13, FirstName = "Norbert", LastName = "Sikora", Pesel = "90010100023", Email = "emp13.user1@example.com", Phone = "500001013", Position = "Support Engineer", Salary = 6400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 14, FirstName = "Piotr", LastName = "Walczak", Pesel = "90010100024", Email = "emp14.user1@example.com", Phone = "500001014", Position = "Business Analyst", Salary = 9300m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 15, FirstName = "Wojciech", LastName = "Czarnecki", Pesel = "90010100025", Email = "emp15.user1@example.com", Phone = "500001015", Position = "Scrum Master", Salary = 10200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 16, FirstName = "Bartłomiej", LastName = "Król", Pesel = "90010100026", Email = "emp16.user1@example.com", Phone = "500001016", Position = "Software Architect", Salary = 14000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 17, FirstName = "Sebastian", LastName = "Szymański", Pesel = "90010100027", Email = "emp17.user1@example.com", Phone = "500001017", Position = "Mobile Developer", Salary = 9600m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 18, FirstName = "Daniel", LastName = "Jasiński", Pesel = "90010100028", Email = "emp18.user1@example.com", Phone = "500001018", Position = "Cloud Engineer", Salary = 12500m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 19, FirstName = "Marcin", LastName = "Zawadzki", Pesel = "90010100029", Email = "emp19.user1@example.com", Phone = "500001019", Position = "Security Specialist", Salary = 13200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 20, FirstName = "Igor", LastName = "Chmielewski", Pesel = "90010100030", Email = "emp20.user1@example.com", Phone = "500001020", Position = "IT Support", Salary = 6000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },

        // … (rekordy 21–50 w tym samym formacie)
        new Employee { Id = 21, FirstName = "Oskar", LastName = "Urbański", Pesel = "90010100031", Email = "emp21.user1@example.com", Phone = "500001021", Position = "Developer", Salary = 8800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 22, FirstName = "Marek", LastName = "Lis", Pesel = "90010100032", Email = "emp22.user1@example.com", Phone = "500001022", Position = "Tester", Salary = 7100m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 23, FirstName = "Krzysztof", LastName = "Bednarek", Pesel = "90010100033", Email = "emp23.user1@example.com", Phone = "500001023", Position = "DevOps Engineer", Salary = 11900m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 24, FirstName = "Dominik", LastName = "Baran", Pesel = "90010100034", Email = "emp24.user1@example.com", Phone = "500001024", Position = "QA Engineer", Salary = 7400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 25, FirstName = "Alan", LastName = "Makowski", Pesel = "90010100035", Email = "emp25.user1@example.com", Phone = "500001025", Position = "System Engineer", Salary = 9500m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 26, FirstName = "Filip", LastName = "Domański", Pesel = "90010100036", Email = "emp26.user1@example.com", Phone = "500001026", Position = "Business Analyst", Salary = 9100m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 27, FirstName = "Szymon", LastName = "Wilk", Pesel = "90010100037", Email = "emp27.user1@example.com", Phone = "500001027", Position = "Developer", Salary = 8900m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 28, FirstName = "Mateusz", LastName = "Malinowski", Pesel = "90010100038", Email = "emp28.user1@example.com", Phone = "500001028", Position = "Cloud Engineer", Salary = 12300m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 29, FirstName = "Artur", LastName = "Jaworski", Pesel = "90010100039", Email = "emp29.user1@example.com", Phone = "500001029", Position = "IT Support", Salary = 6100m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 30, FirstName = "Kacper", LastName = "Ziółkowski", Pesel = "90010100040", Email = "emp30.user1@example.com", Phone = "500001030", Position = "Tester", Salary = 6900m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },

        new Employee { Id = 31, FirstName = "Bogdan", LastName = "Sawicki", Pesel = "90010100041", Email = "emp31.user1@example.com", Phone = "500001031", Position = "Developer", Salary = 9200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 32, FirstName = "Eryk", LastName = "Tomczak", Pesel = "90010100042", Email = "emp32.user1@example.com", Phone = "500001032", Position = "Security Specialist", Salary = 12800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 33, FirstName = "Leon", LastName = "Michalski", Pesel = "90010100043", Email = "emp33.user1@example.com", Phone = "500001033", Position = "QA Engineer", Salary = 7600m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 34, FirstName = "Bruno", LastName = "Staniszewski", Pesel = "90010100044", Email = "emp34.user1@example.com", Phone = "500001034", Position = "DevOps Engineer", Salary = 12100m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 35, FirstName = "Hubert", LastName = "Nowicki", Pesel = "90010100045", Email = "emp35.user1@example.com", Phone = "500001035", Position = "Backend Developer", Salary = 9400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 36, FirstName = "Julian", LastName = "Stefański", Pesel = "90010100046", Email = "emp36.user1@example.com", Phone = "500001036", Position = "Frontend Developer", Salary = 8800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 37, FirstName = "Nikodem", LastName = "Kasprzak", Pesel = "90010100047", Email = "emp37.user1@example.com", Phone = "500001037", Position = "System Administrator", Salary = 8700m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 38, FirstName = "Oliwier", LastName = "Matysiak", Pesel = "90010100048", Email = "emp38.user1@example.com", Phone = "500001038", Position = "Business Analyst", Salary = 9500m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 39, FirstName = "Milan", LastName = "Sadowski", Pesel = "90010100049", Email = "emp39.user1@example.com", Phone = "500001039", Position = "Project Manager", Salary = 10800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 40, FirstName = "Gabriel", LastName = "Rogowski", Pesel = "90010100050", Email = "emp40.user1@example.com", Phone = "500001040", Position = "Developer", Salary = 9100m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },

        new Employee { Id = 41, FirstName = "Natan", LastName = "Mróz", Pesel = "90010100051", Email = "emp41.user1@example.com", Phone = "500001041", Position = "Tester", Salary = 7200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 42, FirstName = "Tymon", LastName = "Korczak", Pesel = "90010100052", Email = "emp42.user1@example.com", Phone = "500001042", Position = "IT Support", Salary = 6200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 43, FirstName = "Emil", LastName = "Kubiak", Pesel = "90010100053", Email = "emp43.user1@example.com", Phone = "500001043", Position = "Developer", Salary = 9050m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 44, FirstName = "Tobiasz", LastName = "Szulc", Pesel = "90010100054", Email = "emp44.user1@example.com", Phone = "500001044", Position = "QA Engineer", Salary = 7400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 45, FirstName = "Borys", LastName = "Wilczyński", Pesel = "90010100055", Email = "emp45.user1@example.com", Phone = "500001045", Position = "Cloud Engineer", Salary = 12400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 46, FirstName = "Aleks", LastName = "Stankiewicz", Pesel = "90010100056", Email = "emp46.user1@example.com", Phone = "500001046", Position = "Security Specialist", Salary = 13000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 47, FirstName = "Kornel", LastName = "Sokołowski", Pesel = "90010100057", Email = "emp47.user1@example.com", Phone = "500001047", Position = "System Engineer", Salary = 9500m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 48, FirstName = "Iwo", LastName = "Głowacki", Pesel = "90010100058", Email = "emp48.user1@example.com", Phone = "500001048", Position = "Developer", Salary = 9000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 49, FirstName = "Max", LastName = "Borowski", Pesel = "90010100059", Email = "emp49.user1@example.com", Phone = "500001049", Position = "Tester", Salary = 7000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },
        new Employee { Id = 50, FirstName = "Alex", LastName = "Andrzejewski", Pesel = "90010100060", Email = "emp50.user1@example.com", Phone = "500001050", Position = "DevOps Engineer", Salary = 12200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user1 },


        // --- USER 2 (51–100) ---
        new Employee { Id = 51, FirstName = "Anna", LastName = "Nowak", Pesel = "90010100101", Email = "emp1.user2@example.com", Phone = "511001001", Position = "HR Manager", Salary = 9500m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 52, FirstName = "Karolina", LastName = "Lis", Pesel = "90010100102", Email = "emp2.user2@example.com", Phone = "511001002", Position = "UX Designer", Salary = 8800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 53, FirstName = "Natalia", LastName = "Konieczna", Pesel = "90010100103", Email = "emp3.user2@example.com", Phone = "511001003", Position = "Recruiter", Salary = 7200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 54, FirstName = "Julia", LastName = "Domańska", Pesel = "90010100104", Email = "emp4.user2@example.com", Phone = "511001004", Position = "HR Specialist", Salary = 7800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 55, FirstName = "Magdalena", LastName = "Krupa", Pesel = "90010100105", Email = "emp5.user2@example.com", Phone = "511001005", Position = "Project Manager", Salary = 11000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 56, FirstName = "Agnieszka", LastName = "Urban", Pesel = "90010100106", Email = "emp6.user2@example.com", Phone = "511001006", Position = "Business Analyst", Salary = 9000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 57, FirstName = "Paulina", LastName = "Jaworska", Pesel = "90010100107", Email = "emp7.user2@example.com", Phone = "511001007", Position = "QA Engineer", Salary = 7600m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 58, FirstName = "Kinga", LastName = "Gajewska", Pesel = "90010100108", Email = "emp8.user2@example.com", Phone = "511001008", Position = "Scrum Master", Salary = 10200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 59, FirstName = "Weronika", LastName = "Wieczorek", Pesel = "90010100109", Email = "emp9.user2@example.com", Phone = "511001009", Position = "HR Manager", Salary = 9800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 60, FirstName = "Alicja", LastName = "Bielawska", Pesel = "90010100110", Email = "emp10.user2@example.com", Phone = "511001010", Position = "UX Researcher", Salary = 8700m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },

        new Employee { Id = 61, FirstName = "Patrycja", LastName = "Ostrowska", Pesel = "90010100111", Email = "emp11.user2@example.com", Phone = "511001011", Position = "Office Manager", Salary = 6400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 62, FirstName = "Ewelina", LastName = "Sobczak", Pesel = "90010100112", Email = "emp12.user2@example.com", Phone = "511001012", Position = "Marketing Specialist", Salary = 8200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 63, FirstName = "Joanna", LastName = "Marciniak", Pesel = "90010100113", Email = "emp13.user2@example.com", Phone = "511001013", Position = "Product Owner", Salary = 11200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 64, FirstName = "Dorota", LastName = "Czarnecka", Pesel = "90010100114", Email = "emp14.user2@example.com", Phone = "511001014", Position = "Project Coordinator", Salary = 7800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 65, FirstName = "Marta", LastName = "Borkowska", Pesel = "90010100115", Email = "emp15.user2@example.com", Phone = "511001015", Position = "Business Consultant", Salary = 9600m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 66, FirstName = "Zuzanna", LastName = "Cieślak", Pesel = "90010100116", Email = "emp16.user2@example.com", Phone = "511001016", Position = "HR Specialist", Salary = 7400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 67, FirstName = "Emilia", LastName = "Piątek", Pesel = "90010100117", Email = "emp17.user2@example.com", Phone = "511001017", Position = "Recruitment Lead", Salary = 9800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 68, FirstName = "Lena", LastName = "Mróz", Pesel = "90010100118", Email = "emp18.user2@example.com", Phone = "511001018", Position = "HR Partner", Salary = 10400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 69, FirstName = "Helena", LastName = "Szymczak", Pesel = "90010100119", Email = "emp19.user2@example.com", Phone = "511001019", Position = "UX Designer", Salary = 8900m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 70, FirstName = "Sara", LastName = "Barańska", Pesel = "90010100120", Email = "emp20.user2@example.com", Phone = "511001020", Position = "Business Analyst", Salary = 9200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },

        new Employee { Id = 71, FirstName = "Katarzyna", LastName = "Zając", Pesel = "90010100121", Email = "emp21.user2@example.com", Phone = "511001021", Position = "Project Manager", Salary = 11100m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 72, FirstName = "Beata", LastName = "Kaczor", Pesel = "90010100122", Email = "emp22.user2@example.com", Phone = "511001022", Position = "Marketing Manager", Salary = 9900m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 73, FirstName = "Justyna", LastName = "Sadowska", Pesel = "90010100123", Email = "emp23.user2@example.com", Phone = "511001023", Position = "HR Coordinator", Salary = 7200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 74, FirstName = "Izabela", LastName = "Kubiak", Pesel = "90010100124", Email = "emp24.user2@example.com", Phone = "511001024", Position = "Scrum Master", Salary = 10100m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 75, FirstName = "Monika", LastName = "Szulc", Pesel = "90010100125", Email = "emp25.user2@example.com", Phone = "511001025", Position = "Business Partner", Salary = 10800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 76, FirstName = "Barbara", LastName = "Chojnacka", Pesel = "90010100126", Email = "emp26.user2@example.com", Phone = "511001026", Position = "HR Specialist", Salary = 7600m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 77, FirstName = "Renata", LastName = "Nowicka", Pesel = "90010100127", Email = "emp27.user2@example.com", Phone = "511001027", Position = "Recruiter", Salary = 7400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 78, FirstName = "Aneta", LastName = "Sikorska", Pesel = "90010100128", Email = "emp28.user2@example.com", Phone = "511001028", Position = "Project Coordinator", Salary = 8000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 79, FirstName = "Gabriela", LastName = "Kulesza", Pesel = "90010100129", Email = "emp29.user2@example.com", Phone = "511001029", Position = "UX Writer", Salary = 8300m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 80, FirstName = "Laura", LastName = "Polak", Pesel = "90010100130", Email = "emp30.user2@example.com", Phone = "511001030", Position = "Business Analyst", Salary = 9400m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },

        new Employee { Id = 81, FirstName = "Nina", LastName = "Kozłowska", Pesel = "90010100131", Email = "emp31.user2@example.com", Phone = "511001031", Position = "HR Manager", Salary = 11500m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 82, FirstName = "Oliwia", LastName = "Jankowska", Pesel = "90010100132", Email = "emp32.user2@example.com", Phone = "511001032", Position = "Marketing Specialist", Salary = 8200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 83, FirstName = "Lidia", LastName = "Pawłowska", Pesel = "90010100133", Email = "emp33.user2@example.com", Phone = "511001033", Position = "Project Manager", Salary = 10900m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 84, FirstName = "Eliza", LastName = "Góra", Pesel = "90010100134", Email = "emp34.user2@example.com", Phone = "511001034", Position = "UX Designer", Salary = 8800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 85, FirstName = "Maja", LastName = "Ratajczak", Pesel = "90010100135", Email = "emp35.user2@example.com", Phone = "511001035", Position = "Scrum Master", Salary = 10050m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 86, FirstName = "Helena", LastName = "Sawicka", Pesel = "90010100136", Email = "emp36.user2@example.com", Phone = "511001036", Position = "HR Specialist", Salary = 7800m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 87, FirstName = "Maria", LastName = "Wasilewska", Pesel = "90010100137", Email = "emp37.user2@example.com", Phone = "511001037", Position = "Business Consultant", Salary = 9700m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 88, FirstName = "Hanna", LastName = "Błaszczyk", Pesel = "90010100138", Email = "emp38.user2@example.com", Phone = "511001038", Position = "Recruitment Specialist", Salary = 7300m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 89, FirstName = "Tatiana", LastName = "Kania", Pesel = "90010100139", Email = "emp39.user2@example.com", Phone = "511001039", Position = "Project Coordinator", Salary = 8100m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 90, FirstName = "Milena", LastName = "Słoń", Pesel = "90010100140", Email = "emp40.user2@example.com", Phone = "511001040", Position = "Business Analyst", Salary = 9500m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },

        new Employee { Id = 91, FirstName = "Iga", LastName = "Leśniak", Pesel = "90010100141", Email = "emp41.user2@example.com", Phone = "511001041", Position = "UX Designer", Salary = 9000m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 92, FirstName = "Karina", LastName = "Piekarska", Pesel = "90010100142", Email = "emp42.user2@example.com", Phone = "511001042", Position = "HR Partner", Salary = 10300m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 93, FirstName = "Dobrawa", LastName = "Pilch", Pesel = "90010100143", Email = "emp43.user2@example.com", Phone = "511001043", Position = "Scrum Master", Salary = 9900m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 94, FirstName = "Olga", LastName = "Świątek", Pesel = "90010100144", Email = "emp44.user2@example.com", Phone = "511001044", Position = "Project Manager", Salary = 11300m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 95, FirstName = "Nadia", LastName = "Wrona", Pesel = "90010100145", Email = "emp45.user2@example.com", Phone = "511001045", Position = "Marketing Specialist", Salary = 8300m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 96, FirstName = "Roksana", LastName = "Danielska", Pesel = "90010100146", Email = "emp46.user2@example.com", Phone = "511001046", Position = "Business Consultant", Salary = 9600m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 97, FirstName = "Sylwia", LastName = "Turkowska", Pesel = "90010100147", Email = "emp47.user2@example.com", Phone = "511001047", Position = "UX Researcher", Salary = 8600m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 98, FirstName = "Tamara", LastName = "Kubińska", Pesel = "90010100148", Email = "emp48.user2@example.com", Phone = "511001048", Position = "Recruitment Lead", Salary = 9900m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 99, FirstName = "Wioletta", LastName = "Grzelak", Pesel = "90010100149", Email = "emp49.user2@example.com", Phone = "511001049", Position = "Project Coordinator", Salary = 8200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 },
        new Employee { Id = 100, FirstName = "Żaneta", LastName = "Karwowska", Pesel = "90010100150", Email = "emp50.user2@example.com", Phone = "511001050", Position = "HR Manager", Salary = 11200m, HireDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UserId = user2 }
            );

            modelBuilder.Entity<Address>().HasData(
        new Address { Id = 1, City = "Warszawa", StreetName = "Polna", HouseNumber = "12", ApartamentNumber = "3", PostalCode = "00-001", EmployeeId = 1 },
        new Address { Id = 2, City = "Łódź", StreetName = "Kwiatowa", HouseNumber = "8", ApartamentNumber = "2", PostalCode = "91-005", EmployeeId = 2 },
        new Address { Id = 3, City = "Gdańsk", StreetName = "Morska", HouseNumber = "5", ApartamentNumber = "10", PostalCode = "80-111", EmployeeId = 3 },

        new Address { Id = 4, City = "Kraków", StreetName = "Długa", HouseNumber = "5A", ApartamentNumber = "7", PostalCode = "31-002", EmployeeId = 4 },
        new Address { Id = 5, City = "Poznań", StreetName = "Lechicka", HouseNumber = "15", ApartamentNumber = "1", PostalCode = "60-101", EmployeeId = 5 },
        new Address { Id = 6, City = "Wrocław", StreetName = "Słoneczna", HouseNumber = "22", ApartamentNumber = "6", PostalCode = "50-500", EmployeeId = 6 },

        new Address { Id = 7, City = "Szczecin", StreetName = "Nadodrzańska", HouseNumber = "9", ApartamentNumber = "4", PostalCode = "70-010", EmployeeId = 7 },
        new Address { Id = 8, City = "Bydgoszcz", StreetName = "Parkowa", HouseNumber = "3", ApartamentNumber = "2", PostalCode = "85-020", EmployeeId = 8 },
        new Address { Id = 9, City = "Lublin", StreetName = "Lipowa", HouseNumber = "18", ApartamentNumber = "5", PostalCode = "20-027", EmployeeId = 9 },
        new Address { Id = 10, City = "Katowice", StreetName = "Silesia", HouseNumber = "7", ApartamentNumber = "1", PostalCode = "40-001", EmployeeId = 10 },

        new Address { Id = 11, City = "Białystok", StreetName = "Wesoła", HouseNumber = "11", ApartamentNumber = "2", PostalCode = "15-002", EmployeeId = 11 },
        new Address { Id = 12, City = "Rzeszów", StreetName = "Zamkowa", HouseNumber = "6", ApartamentNumber = "3", PostalCode = "35-030", EmployeeId = 12 },
        new Address { Id = 13, City = "Opole", StreetName = "Szkolna", HouseNumber = "13", ApartamentNumber = "6", PostalCode = "45-060", EmployeeId = 13 },
        new Address { Id = 14, City = "Torun", StreetName = "Planetarna", HouseNumber = "9B", ApartamentNumber = "4", PostalCode = "87-100", EmployeeId = 14 },
        new Address { Id = 15, City = "Radom", StreetName = "Reymonta", HouseNumber = "4", ApartamentNumber = "2", PostalCode = "26-600", EmployeeId = 15 },

        new Address { Id = 16, City = "Kielce", StreetName = "Jesienna", HouseNumber = "21", ApartamentNumber = "7", PostalCode = "25-001", EmployeeId = 16 },
        new Address { Id = 17, City = "Gliwice", StreetName = "Energetyków", HouseNumber = "10", ApartamentNumber = "1", PostalCode = "44-100", EmployeeId = 17 },
        new Address { Id = 18, City = "Tychy", StreetName = "Sportowa", HouseNumber = "8", ApartamentNumber = "2", PostalCode = "43-100", EmployeeId = 18 },
        new Address { Id = 19, City = "Zabrze", StreetName = "Kolejowa", HouseNumber = "3", ApartamentNumber = "5", PostalCode = "41-800", EmployeeId = 19 },
        new Address { Id = 20, City = "Legnica", StreetName = "Rycerska", HouseNumber = "14", ApartamentNumber = "6", PostalCode = "59-200", EmployeeId = 20 },

        // 21–40
        new Address { Id = 21, City = "Elbląg", StreetName = "Widok", HouseNumber = "6", ApartamentNumber = "1", PostalCode = "82-300", EmployeeId = 21 },
        new Address { Id = 22, City = "Płock", StreetName = "Podmiejska", HouseNumber = "9", ApartamentNumber = "4", PostalCode = "09-400", EmployeeId = 22 },
        new Address { Id = 23, City = "Koszalin", StreetName = "Leśna", HouseNumber = "12", ApartamentNumber = "2", PostalCode = "75-001", EmployeeId = 23 },
        new Address { Id = 24, City = "Olsztyn", StreetName = "Jeziorna", HouseNumber = "5", ApartamentNumber = "3", PostalCode = "10-300", EmployeeId = 24 },
        new Address { Id = 25, City = "Gdynia", StreetName = "Portowa", HouseNumber = "16", ApartamentNumber = "8", PostalCode = "81-001", EmployeeId = 25 },
        new Address { Id = 26, City = "Sopot", StreetName = "Plażowa", HouseNumber = "2A", ApartamentNumber = "1", PostalCode = "81-701", EmployeeId = 26 },
        new Address { Id = 27, City = "Zielona Góra", StreetName = "Winna", HouseNumber = "7", ApartamentNumber = "2", PostalCode = "65-001", EmployeeId = 27 },
        new Address { Id = 28, City = "Gorzów", StreetName = "Mostowa", HouseNumber = "11", ApartamentNumber = "5", PostalCode = "66-400", EmployeeId = 28 },
        new Address { Id = 29, City = "Wałbrzych", StreetName = "Górnicza", HouseNumber = "18", ApartamentNumber = "6", PostalCode = "58-300", EmployeeId = 29 },
        new Address { Id = 30, City = "Jelenia Góra", StreetName = "Karkonoska", HouseNumber = "4", ApartamentNumber = "3", PostalCode = "58-500", EmployeeId = 30 },

        new Address { Id = 31, City = "Nowy Sącz", StreetName = "Rynek", HouseNumber = "3", ApartamentNumber = "2", PostalCode = "33-300", EmployeeId = 31 },
        new Address { Id = 32, City = "Tarnów", StreetName = "Pilźnieńska", HouseNumber = "20", ApartamentNumber = "7", PostalCode = "33-100", EmployeeId = 32 },
        new Address { Id = 33, City = "Chorzów", StreetName = "Metalowa", HouseNumber = "9", ApartamentNumber = "1", PostalCode = "41-500", EmployeeId = 33 },
        new Address { Id = 34, City = "Ruda Śląska", StreetName = "Śląska", HouseNumber = "8", ApartamentNumber = "4", PostalCode = "41-700", EmployeeId = 34 },
        new Address { Id = 35, City = "Piekary Śląskie", StreetName = "Górka", HouseNumber = "6", ApartamentNumber = "2", PostalCode = "41-940", EmployeeId = 35 },
        new Address { Id = 36, City = "Dąbrowa Górnicza", StreetName = "Przemysłowa", HouseNumber = "14", ApartamentNumber = "3", PostalCode = "41-300", EmployeeId = 36 },
        new Address { Id = 37, City = "Jaworzno", StreetName = "Graniczna", HouseNumber = "11", ApartamentNumber = "6", PostalCode = "43-600", EmployeeId = 37 },
        new Address { Id = 38, City = "Mysłowice", StreetName = "Miła", HouseNumber = "5", ApartamentNumber = "2", PostalCode = "41-400", EmployeeId = 38 },
        new Address { Id = 39, City = "Tarnowskie Góry", StreetName = "Zamkowa", HouseNumber = "7", ApartamentNumber = "4", PostalCode = "42-600", EmployeeId = 39 },
        new Address { Id = 40, City = "Pabianice", StreetName = "Fabryczna", HouseNumber = "10", ApartamentNumber = "1", PostalCode = "95-200", EmployeeId = 40 },

        // 41–60
        new Address { Id = 41, City = "Zamość", StreetName = "Hetmańska", HouseNumber = "3", ApartamentNumber = "2", PostalCode = "22-400", EmployeeId = 41 },
        new Address { Id = 42, City = "Chełm", StreetName = "Dworcowa", HouseNumber = "6", ApartamentNumber = "4", PostalCode = "22-100", EmployeeId = 42 },
        new Address { Id = 43, City = "Ełk", StreetName = "Mazurska", HouseNumber = "9", ApartamentNumber = "1", PostalCode = "19-300", EmployeeId = 43 },
        new Address { Id = 44, City = "Świnoujście", StreetName = "Nadmorska", HouseNumber = "2", ApartamentNumber = "3", PostalCode = "72-600", EmployeeId = 44 },
        new Address { Id = 45, City = "Kołobrzeg", StreetName = "Bałtycka", HouseNumber = "15", ApartamentNumber = "5", PostalCode = "78-100", EmployeeId = 45 },
        new Address { Id = 46, City = "Puławy", StreetName = "Mostowa", HouseNumber = "7", ApartamentNumber = "2", PostalCode = "24-100", EmployeeId = 46 },
        new Address { Id = 47, City = "Przemyśl", StreetName = "Forteczna", HouseNumber = "11", ApartamentNumber = "6", PostalCode = "37-700", EmployeeId = 47 },
        new Address { Id = 48, City = "Krosno", StreetName = "Lotników", HouseNumber = "8", ApartamentNumber = "4", PostalCode = "38-400", EmployeeId = 48 },
        new Address { Id = 49, City = "Sanok", StreetName = "Górska", HouseNumber = "5", ApartamentNumber = "3", PostalCode = "38-500", EmployeeId = 49 },
        new Address { Id = 50, City = "Leszno", StreetName = "Kolejowa", HouseNumber = "12", ApartamentNumber = "1", PostalCode = "64-100", EmployeeId = 50 },

        // 51–100 (drugi użytkownik, ten sam schemat)
        new Address { Id = 51, City = "Warszawa", StreetName = "Żurawia", HouseNumber = "3", ApartamentNumber = "2", PostalCode = "00-502", EmployeeId = 51 },
        new Address { Id = 52, City = "Łódź", StreetName = "Piotrkowska", HouseNumber = "220", ApartamentNumber = "5", PostalCode = "90-001", EmployeeId = 52 },
        new Address { Id = 53, City = "Gdańsk", StreetName = "Stoczniowa", HouseNumber = "7", ApartamentNumber = "1", PostalCode = "80-750", EmployeeId = 53 },
        new Address { Id = 54, City = "Kraków", StreetName = "Floriańska", HouseNumber = "8", ApartamentNumber = "4", PostalCode = "31-019", EmployeeId = 54 },
        new Address { Id = 55, City = "Poznań", StreetName = "Towarowa", HouseNumber = "5", ApartamentNumber = "6", PostalCode = "60-101", EmployeeId = 55 },
        new Address { Id = 56, City = "Wrocław", StreetName = "Szewska", HouseNumber = "10", ApartamentNumber = "2", PostalCode = "50-122", EmployeeId = 56 },
        new Address { Id = 57, City = "Szczecin", StreetName = "Krzywoustego", HouseNumber = "12", ApartamentNumber = "3", PostalCode = "70-246", EmployeeId = 57 },
        new Address { Id = 58, City = "Lublin", StreetName = "Narutowicza", HouseNumber = "21", ApartamentNumber = "7", PostalCode = "20-001", EmployeeId = 58 },
        new Address { Id = 59, City = "Gdynia", StreetName = "Świętojańska", HouseNumber = "4", ApartamentNumber = "1", PostalCode = "81-372", EmployeeId = 59 },
        new Address { Id = 60, City = "Katowice", StreetName = "Kościuszki", HouseNumber = "9", ApartamentNumber = "2", PostalCode = "40-001", EmployeeId = 60 },

        // 61–100 (ten sam wzór, inne numery)
        new Address { Id = 61, City = "Rzeszów", StreetName = "Lawendowa", HouseNumber = "6", ApartamentNumber = "4", PostalCode = "35-205", EmployeeId = 61 },
        new Address { Id = 62, City = "Białystok", StreetName = "Ciepła", HouseNumber = "14", ApartamentNumber = "3", PostalCode = "15-472", EmployeeId = 62 },
        new Address { Id = 63, City = "Opole", StreetName = "Wróblewskiego", HouseNumber = "8", ApartamentNumber = "5", PostalCode = "45-760", EmployeeId = 63 },
        new Address { Id = 64, City = "Olsztyn", StreetName = "Dworcowa", HouseNumber = "2", ApartamentNumber = "1", PostalCode = "10-436", EmployeeId = 64 },
        new Address { Id = 65, City = "Koszalin", StreetName = "Zwycięstwa", HouseNumber = "18", ApartamentNumber = "7", PostalCode = "75-001", EmployeeId = 65 },
        new Address { Id = 66, City = "Toruń", StreetName = "Grudziądzka", HouseNumber = "11", ApartamentNumber = "3", PostalCode = "87-100", EmployeeId = 66 },
        new Address { Id = 67, City = "Radom", StreetName = "Warszawska", HouseNumber = "9", ApartamentNumber = "2", PostalCode = "26-600", EmployeeId = 67 },
        new Address { Id = 68, City = "Zielona Góra", StreetName = "Jagodowa", HouseNumber = "7", ApartamentNumber = "4", PostalCode = "65-001", EmployeeId = 68 },
        new Address { Id = 69, City = "Legnica", StreetName = "Piekarska", HouseNumber = "12", ApartamentNumber = "5", PostalCode = "59-220", EmployeeId = 69 },
        new Address { Id = 70, City = "Elbląg", StreetName = "Fromborska", HouseNumber = "5", ApartamentNumber = "1", PostalCode = "82-300", EmployeeId = 70 },

        // 71–80
        new Address { Id = 71, City = "Płock", StreetName = "Kasztanowa", HouseNumber = "16", ApartamentNumber = "6", PostalCode = "09-400", EmployeeId = 71 },
        new Address { Id = 72, City = "Przemyśl", StreetName = "Sanowa", HouseNumber = "4", ApartamentNumber = "3", PostalCode = "37-700", EmployeeId = 72 },
        new Address { Id = 73, City = "Ełk", StreetName = "Nadrzeczna", HouseNumber = "10", ApartamentNumber = "2", PostalCode = "19-300", EmployeeId = 73 },
        new Address { Id = 74, City = "Krosno", StreetName = "Naftowa", HouseNumber = "6", ApartamentNumber = "1", PostalCode = "38-400", EmployeeId = 74 },
        new Address { Id = 75, City = "Sanok", StreetName = "Ogrodowa", HouseNumber = "13", ApartamentNumber = "7", PostalCode = "38-500", EmployeeId = 75 },
        new Address { Id = 76, City = "Leszno", StreetName = "Miła", HouseNumber = "8", ApartamentNumber = "4", PostalCode = "64-100", EmployeeId = 76 },
        new Address { Id = 77, City = "Jaworzno", StreetName = "Dolna", HouseNumber = "3", ApartamentNumber = "1", PostalCode = "43-600", EmployeeId = 77 },
        new Address { Id = 78, City = "Mysłowice", StreetName = "Wiosenna", HouseNumber = "9", ApartamentNumber = "2", PostalCode = "41-400", EmployeeId = 78 },
        new Address { Id = 79, City = "Chorzów", StreetName = "Parkowa", HouseNumber = "7", ApartamentNumber = "3", PostalCode = "41-500", EmployeeId = 79 },
        new Address { Id = 80, City = "Gliwice", StreetName = "Zielona", HouseNumber = "14", ApartamentNumber = "6", PostalCode = "44-100", EmployeeId = 80 },

        // 81–100
        new Address { Id = 81, City = "Tychy", StreetName = "Jasna", HouseNumber = "5", ApartamentNumber = "2", PostalCode = "43-100", EmployeeId = 81 },
        new Address { Id = 82, City = "Zabrze", StreetName = "Łąkowa", HouseNumber = "6", ApartamentNumber = "1", PostalCode = "41-800", EmployeeId = 82 },
        new Address { Id = 83, City = "Bytom", StreetName = "Krótka", HouseNumber = "3", ApartamentNumber = "4", PostalCode = "41-902", EmployeeId = 83 },
        new Address { Id = 84, City = "Ruda Śląska", StreetName = "Wiejska", HouseNumber = "12", ApartamentNumber = "5", PostalCode = "41-709", EmployeeId = 84 },
        new Address { Id = 85, City = "Tarnów", StreetName = "Nowa", HouseNumber = "8", ApartamentNumber = "3", PostalCode = "33-100", EmployeeId = 85 },
        new Address { Id = 86, City = "Nowy Sącz", StreetName = "Południowa", HouseNumber = "15", ApartamentNumber = "7", PostalCode = "33-300", EmployeeId = 86 },
        new Address { Id = 87, City = "Jelenia Góra", StreetName = "Sudecka", HouseNumber = "10", ApartamentNumber = "2", PostalCode = "58-500", EmployeeId = 87 },
        new Address { Id = 88, City = "Wałbrzych", StreetName = "Sienkiewicza", HouseNumber = "4", ApartamentNumber = "1", PostalCode = "58-300", EmployeeId = 88 },
        new Address { Id = 89, City = "Gorzów", StreetName = "Dworcowa", HouseNumber = "11", ApartamentNumber = "6", PostalCode = "66-400", EmployeeId = 89 },
        new Address { Id = 90, City = "Zielona Góra", StreetName = "Brzozowa", HouseNumber = "9", ApartamentNumber = "2", PostalCode = "65-001", EmployeeId = 90 },

        new Address { Id = 91, City = "Sopot", StreetName = "Mickiewicza", HouseNumber = "7", ApartamentNumber = "3", PostalCode = "81-701", EmployeeId = 91 },
        new Address { Id = 92, City = "Gdynia", StreetName = "Orłowska", HouseNumber = "5", ApartamentNumber = "4", PostalCode = "81-522", EmployeeId = 92 },
        new Address { Id = 93, City = "Kraków", StreetName = "Grodzka", HouseNumber = "12", ApartamentNumber = "5", PostalCode = "31-044", EmployeeId = 93 },
        new Address { Id = 94, City = "Warszawa", StreetName = "Marszałkowska", HouseNumber = "102", ApartamentNumber = "6", PostalCode = "00-017", EmployeeId = 94 },
        new Address { Id = 95, City = "Łódź", StreetName = "Sienkiewicza", HouseNumber = "14", ApartamentNumber = "2", PostalCode = "90-113", EmployeeId = 95 },
        new Address { Id = 96, City = "Gdańsk", StreetName = "Okopowa", HouseNumber = "3", ApartamentNumber = "4", PostalCode = "80-819", EmployeeId = 96 },
        new Address { Id = 97, City = "Wrocław", StreetName = "Kazimierza", HouseNumber = "6", ApartamentNumber = "1", PostalCode = "50-001", EmployeeId = 97 },
        new Address { Id = 98, City = "Poznań", StreetName = "Śniadeckich", HouseNumber = "9", ApartamentNumber = "3", PostalCode = "60-776", EmployeeId = 98 },
        new Address { Id = 99, City = "Katowice", StreetName = "Dworcowa", HouseNumber = "8", ApartamentNumber = "2", PostalCode = "40-001", EmployeeId = 99 },
        new Address { Id = 100, City = "Lublin", StreetName = "Grodzka", HouseNumber = "7", ApartamentNumber = "5", PostalCode = "20-112", EmployeeId = 100 }

            );
        }
    }
}
