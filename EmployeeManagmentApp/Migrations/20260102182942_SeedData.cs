using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagmentApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "HireDate", "LastName", "Pesel", "Phone", "Position", "Salary", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9904), "emp1.user1@example.com", "Jan", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9903), "Nowak", "90010100011", "500001001", "Developer", 8000m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 2, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9907), "emp2.user1@example.com", "Adam", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9907), "Kowalczyk", "90010100012", "500001002", "Tester", 7000m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 3, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9910), "emp3.user1@example.com", "Kamil", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9910), "Zieliński", "90010100013", "500001003", "Project Manager", 10500m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 4, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9913), "emp4.user1@example.com", "Paweł", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9912), "Wójcik", "90010100014", "500001004", "HR Specialist", 6500m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 5, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9915), "emp5.user1@example.com", "Michał", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9915), "Mazur", "90010100015", "500001005", "DevOps Engineer", 12000m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 6, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9918), "emp6.user1@example.com", "Tomasz", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9917), "Piotrowski", "90010100016", "500001006", "Backend Developer", 9000m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 7, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9921), "emp7.user1@example.com", "Karol", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9920), "Kaczmarek", "90010100017", "500001007", "Frontend Developer", 8800m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 8, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9923), "emp8.user1@example.com", "Damian", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9923), "Grabowski", "90010100018", "500001008", "UX Designer", 9100m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 9, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9926), "emp9.user1@example.com", "Konrad", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9926), "Olszewski", "90010100019", "500001009", "Data Analyst", 9800m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 10, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9929), "emp10.user1@example.com", "Łukasz", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9928), "Pawlak", "90010100020", "500001010", "System Administrator", 8600m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 11, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9932), "emp11.user1@example.com", "Rafał", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9931), "Duda", "90010100021", "500001011", "QA Engineer", 7200m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 12, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9934), "emp12.user1@example.com", "Patryk", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9934), "Witkowski", "90010100022", "500001012", "DevOps Engineer", 11800m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 13, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9982), "emp13.user1@example.com", "Norbert", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9981), "Sikora", "90010100023", "500001013", "Support Engineer", 6400m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 14, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9985), "emp14.user1@example.com", "Piotr", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9984), "Walczak", "90010100024", "500001014", "Business Analyst", 9300m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 15, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9987), "emp15.user1@example.com", "Wojciech", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9987), "Czarnecki", "90010100025", "500001015", "Scrum Master", 10200m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 16, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9991), "emp16.user1@example.com", "Bartłomiej", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9990), "Król", "90010100026", "500001016", "Software Architect", 14000m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 17, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9993), "emp17.user1@example.com", "Sebastian", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9993), "Szymański", "90010100027", "500001017", "Mobile Developer", 9600m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 18, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9996), "emp18.user1@example.com", "Daniel", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9995), "Jasiński", "90010100028", "500001018", "Cloud Engineer", 12500m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 19, new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9998), "emp19.user1@example.com", "Marcin", new DateTime(2026, 1, 2, 18, 29, 41, 912, DateTimeKind.Utc).AddTicks(9998), "Zawadzki", "90010100029", "500001019", "Security Specialist", 13200m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 20, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(2), "emp20.user1@example.com", "Igor", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc), "Chmielewski", "90010100030", "500001020", "IT Support", 6000m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 21, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(5), "emp21.user1@example.com", "Oskar", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(5), "Urbański", "90010100031", "500001021", "Developer", 8800m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 22, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(7), "emp22.user1@example.com", "Marek", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(7), "Lis", "90010100032", "500001022", "Tester", 7100m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 23, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(10), "emp23.user1@example.com", "Krzysztof", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(10), "Bednarek", "90010100033", "500001023", "DevOps Engineer", 11900m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 24, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(12), "emp24.user1@example.com", "Dominik", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(12), "Baran", "90010100034", "500001024", "QA Engineer", 7400m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 25, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(15), "emp25.user1@example.com", "Alan", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(14), "Makowski", "90010100035", "500001025", "System Engineer", 9500m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 26, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(17), "emp26.user1@example.com", "Filip", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(17), "Domański", "90010100036", "500001026", "Business Analyst", 9100m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 27, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(20), "emp27.user1@example.com", "Szymon", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(19), "Wilk", "90010100037", "500001027", "Developer", 8900m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 28, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(22), "emp28.user1@example.com", "Mateusz", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(22), "Malinowski", "90010100038", "500001028", "Cloud Engineer", 12300m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 29, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(25), "emp29.user1@example.com", "Artur", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(24), "Jaworski", "90010100039", "500001029", "IT Support", 6100m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 30, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(27), "emp30.user1@example.com", "Kacper", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(27), "Ziółkowski", "90010100040", "500001030", "Tester", 6900m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 31, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(30), "emp31.user1@example.com", "Bogdan", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(29), "Sawicki", "90010100041", "500001031", "Developer", 9200m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 32, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(32), "emp32.user1@example.com", "Eryk", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(32), "Tomczak", "90010100042", "500001032", "Security Specialist", 12800m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 33, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(35), "emp33.user1@example.com", "Leon", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(35), "Michalski", "90010100043", "500001033", "QA Engineer", 7600m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 34, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(37), "emp34.user1@example.com", "Bruno", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(37), "Staniszewski", "90010100044", "500001034", "DevOps Engineer", 12100m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 35, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(40), "emp35.user1@example.com", "Hubert", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(40), "Nowicki", "90010100045", "500001035", "Backend Developer", 9400m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 36, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(43), "emp36.user1@example.com", "Julian", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(42), "Stefański", "90010100046", "500001036", "Frontend Developer", 8800m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 37, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(45), "emp37.user1@example.com", "Nikodem", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(45), "Kasprzak", "90010100047", "500001037", "System Administrator", 8700m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 38, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(48), "emp38.user1@example.com", "Oliwier", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(48), "Matysiak", "90010100048", "500001038", "Business Analyst", 9500m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 39, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(50), "emp39.user1@example.com", "Milan", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(50), "Sadowski", "90010100049", "500001039", "Project Manager", 10800m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 40, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(54), "emp40.user1@example.com", "Gabriel", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(54), "Rogowski", "90010100050", "500001040", "Developer", 9100m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 41, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(57), "emp41.user1@example.com", "Natan", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(56), "Mróz", "90010100051", "500001041", "Tester", 7200m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 42, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(59), "emp42.user1@example.com", "Tymon", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(59), "Korczak", "90010100052", "500001042", "IT Support", 6200m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 43, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(62), "emp43.user1@example.com", "Emil", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(61), "Kubiak", "90010100053", "500001043", "Developer", 9050m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 44, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(64), "emp44.user1@example.com", "Tobiasz", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(64), "Szulc", "90010100054", "500001044", "QA Engineer", 7400m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 45, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(67), "emp45.user1@example.com", "Borys", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(66), "Wilczyński", "90010100055", "500001045", "Cloud Engineer", 12400m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 46, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(69), "emp46.user1@example.com", "Aleks", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(69), "Stankiewicz", "90010100056", "500001046", "Security Specialist", 13000m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 47, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(72), "emp47.user1@example.com", "Kornel", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(71), "Sokołowski", "90010100057", "500001047", "System Engineer", 9500m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 48, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(74), "emp48.user1@example.com", "Iwo", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(74), "Głowacki", "90010100058", "500001048", "Developer", 9000m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 49, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(78), "emp49.user1@example.com", "Max", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(78), "Borowski", "90010100059", "500001049", "Tester", 7000m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 50, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(80), "emp50.user1@example.com", "Alex", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(80), "Andrzejewski", "90010100060", "500001050", "DevOps Engineer", 12200m, null, "a8f129a4-d268-402f-9d89-bb2b5ce1ef2f" },
                    { 51, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(83), "emp1.user2@example.com", "Anna", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(83), "Nowak", "90010100101", "511001001", "HR Manager", 9500m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 52, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(85), "emp2.user2@example.com", "Karolina", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(85), "Lis", "90010100102", "511001002", "UX Designer", 8800m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 53, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(88), "emp3.user2@example.com", "Natalia", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(87), "Konieczna", "90010100103", "511001003", "Recruiter", 7200m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 54, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(90), "emp4.user2@example.com", "Julia", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(90), "Domańska", "90010100104", "511001004", "HR Specialist", 7800m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 55, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(92), "emp5.user2@example.com", "Magdalena", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(92), "Krupa", "90010100105", "511001005", "Project Manager", 11000m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 56, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(95), "emp6.user2@example.com", "Agnieszka", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(95), "Urban", "90010100106", "511001006", "Business Analyst", 9000m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 57, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(98), "emp7.user2@example.com", "Paulina", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(97), "Jaworska", "90010100107", "511001007", "QA Engineer", 7600m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 58, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(100), "emp8.user2@example.com", "Kinga", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(100), "Gajewska", "90010100108", "511001008", "Scrum Master", 10200m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 59, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(103), "emp9.user2@example.com", "Weronika", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(102), "Wieczorek", "90010100109", "511001009", "HR Manager", 9800m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 60, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(105), "emp10.user2@example.com", "Alicja", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(105), "Bielawska", "90010100110", "511001010", "UX Researcher", 8700m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 61, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(108), "emp11.user2@example.com", "Patrycja", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(107), "Ostrowska", "90010100111", "511001011", "Office Manager", 6400m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 62, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(110), "emp12.user2@example.com", "Ewelina", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(110), "Sobczak", "90010100112", "511001012", "Marketing Specialist", 8200m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 63, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(113), "emp13.user2@example.com", "Joanna", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(113), "Marciniak", "90010100113", "511001013", "Product Owner", 11200m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 64, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(115), "emp14.user2@example.com", "Dorota", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(115), "Czarnecka", "90010100114", "511001014", "Project Coordinator", 7800m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 65, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(118), "emp15.user2@example.com", "Marta", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(117), "Borkowska", "90010100115", "511001015", "Business Consultant", 9600m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 66, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(120), "emp16.user2@example.com", "Zuzanna", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(120), "Cieślak", "90010100116", "511001016", "HR Specialist", 7400m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 67, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(123), "emp17.user2@example.com", "Emilia", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(122), "Piątek", "90010100117", "511001017", "Recruitment Lead", 9800m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 68, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(125), "emp18.user2@example.com", "Lena", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(125), "Mróz", "90010100118", "511001018", "HR Partner", 10400m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 69, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(128), "emp19.user2@example.com", "Helena", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(127), "Szymczak", "90010100119", "511001019", "UX Designer", 8900m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 70, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(130), "emp20.user2@example.com", "Sara", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(130), "Barańska", "90010100120", "511001020", "Business Analyst", 9200m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 71, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(133), "emp21.user2@example.com", "Katarzyna", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(132), "Zając", "90010100121", "511001021", "Project Manager", 11100m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 72, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(136), "emp22.user2@example.com", "Beata", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(135), "Kaczor", "90010100122", "511001022", "Marketing Manager", 9900m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 73, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(174), "emp23.user2@example.com", "Justyna", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(173), "Sadowska", "90010100123", "511001023", "HR Coordinator", 7200m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 74, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(177), "emp24.user2@example.com", "Izabela", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(176), "Kubiak", "90010100124", "511001024", "Scrum Master", 10100m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 75, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(179), "emp25.user2@example.com", "Monika", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(179), "Szulc", "90010100125", "511001025", "Business Partner", 10800m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 76, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(182), "emp26.user2@example.com", "Barbara", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(181), "Chojnacka", "90010100126", "511001026", "HR Specialist", 7600m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 77, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(184), "emp27.user2@example.com", "Renata", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(184), "Nowicka", "90010100127", "511001027", "Recruiter", 7400m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 78, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(187), "emp28.user2@example.com", "Aneta", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(186), "Sikorska", "90010100128", "511001028", "Project Coordinator", 8000m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 79, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(189), "emp29.user2@example.com", "Gabriela", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(189), "Kulesza", "90010100129", "511001029", "UX Writer", 8300m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 80, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(192), "emp30.user2@example.com", "Laura", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(191), "Polak", "90010100130", "511001030", "Business Analyst", 9400m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 81, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(194), "emp31.user2@example.com", "Nina", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(194), "Kozłowska", "90010100131", "511001031", "HR Manager", 11500m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 82, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(197), "emp32.user2@example.com", "Oliwia", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(196), "Jankowska", "90010100132", "511001032", "Marketing Specialist", 8200m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 83, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(200), "emp33.user2@example.com", "Lidia", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(199), "Pawłowska", "90010100133", "511001033", "Project Manager", 10900m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 84, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(202), "emp34.user2@example.com", "Eliza", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(202), "Góra", "90010100134", "511001034", "UX Designer", 8800m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 85, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(205), "emp35.user2@example.com", "Maja", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(204), "Ratajczak", "90010100135", "511001035", "Scrum Master", 10050m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 86, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(208), "emp36.user2@example.com", "Helena", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(207), "Sawicka", "90010100136", "511001036", "HR Specialist", 7800m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 87, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(210), "emp37.user2@example.com", "Maria", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(210), "Wasilewska", "90010100137", "511001037", "Business Consultant", 9700m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 88, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(213), "emp38.user2@example.com", "Hanna", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(212), "Błaszczyk", "90010100138", "511001038", "Recruitment Specialist", 7300m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 89, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(215), "emp39.user2@example.com", "Tatiana", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(215), "Kania", "90010100139", "511001039", "Project Coordinator", 8100m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 90, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(218), "emp40.user2@example.com", "Milena", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(218), "Słoń", "90010100140", "511001040", "Business Analyst", 9500m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 91, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(221), "emp41.user2@example.com", "Iga", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(220), "Leśniak", "90010100141", "511001041", "UX Designer", 9000m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 92, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(223), "emp42.user2@example.com", "Karina", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(223), "Piekarska", "90010100142", "511001042", "HR Partner", 10300m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 93, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(226), "emp43.user2@example.com", "Dobrawa", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(226), "Pilch", "90010100143", "511001043", "Scrum Master", 9900m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 94, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(229), "emp44.user2@example.com", "Olga", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(228), "Świątek", "90010100144", "511001044", "Project Manager", 11300m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 95, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(231), "emp45.user2@example.com", "Nadia", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(231), "Wrona", "90010100145", "511001045", "Marketing Specialist", 8300m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 96, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(234), "emp46.user2@example.com", "Roksana", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(234), "Danielska", "90010100146", "511001046", "Business Consultant", 9600m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 97, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(237), "emp47.user2@example.com", "Sylwia", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(236), "Turkowska", "90010100147", "511001047", "UX Researcher", 8600m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 98, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(239), "emp48.user2@example.com", "Tamara", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(239), "Kubińska", "90010100148", "511001048", "Recruitment Lead", 9900m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 99, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(242), "emp49.user2@example.com", "Wioletta", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(242), "Grzelak", "90010100149", "511001049", "Project Coordinator", 8200m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" },
                    { 100, new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(245), "emp50.user2@example.com", "Żaneta", new DateTime(2026, 1, 2, 18, 29, 41, 913, DateTimeKind.Utc).AddTicks(244), "Karwowska", "90010100150", "511001050", "HR Manager", 11200m, null, "d5a58238-5527-423b-90bd-ae0ae60a71b5" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ApartamentNumber", "City", "EmployeeId", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[,]
                {
                    { 1, "3", "Warszawa", 1, "12", "00-001", "Polna" },
                    { 2, "2", "Łódź", 2, "8", "91-005", "Kwiatowa" },
                    { 3, "10", "Gdańsk", 3, "5", "80-111", "Morska" },
                    { 4, "7", "Kraków", 4, "5A", "31-002", "Długa" },
                    { 5, "1", "Poznań", 5, "15", "60-101", "Lechicka" },
                    { 6, "6", "Wrocław", 6, "22", "50-500", "Słoneczna" },
                    { 7, "4", "Szczecin", 7, "9", "70-010", "Nadodrzańska" },
                    { 8, "2", "Bydgoszcz", 8, "3", "85-020", "Parkowa" },
                    { 9, "5", "Lublin", 9, "18", "20-027", "Lipowa" },
                    { 10, "1", "Katowice", 10, "7", "40-001", "Silesia" },
                    { 11, "2", "Białystok", 11, "11", "15-002", "Wesoła" },
                    { 12, "3", "Rzeszów", 12, "6", "35-030", "Zamkowa" },
                    { 13, "6", "Opole", 13, "13", "45-060", "Szkolna" },
                    { 14, "4", "Torun", 14, "9B", "87-100", "Planetarna" },
                    { 15, "2", "Radom", 15, "4", "26-600", "Reymonta" },
                    { 16, "7", "Kielce", 16, "21", "25-001", "Jesienna" },
                    { 17, "1", "Gliwice", 17, "10", "44-100", "Energetyków" },
                    { 18, "2", "Tychy", 18, "8", "43-100", "Sportowa" },
                    { 19, "5", "Zabrze", 19, "3", "41-800", "Kolejowa" },
                    { 20, "6", "Legnica", 20, "14", "59-200", "Rycerska" },
                    { 21, "1", "Elbląg", 21, "6", "82-300", "Widok" },
                    { 22, "4", "Płock", 22, "9", "09-400", "Podmiejska" },
                    { 23, "2", "Koszalin", 23, "12", "75-001", "Leśna" },
                    { 24, "3", "Olsztyn", 24, "5", "10-300", "Jeziorna" },
                    { 25, "8", "Gdynia", 25, "16", "81-001", "Portowa" },
                    { 26, "1", "Sopot", 26, "2A", "81-701", "Plażowa" },
                    { 27, "2", "Zielona Góra", 27, "7", "65-001", "Winna" },
                    { 28, "5", "Gorzów", 28, "11", "66-400", "Mostowa" },
                    { 29, "6", "Wałbrzych", 29, "18", "58-300", "Górnicza" },
                    { 30, "3", "Jelenia Góra", 30, "4", "58-500", "Karkonoska" },
                    { 31, "2", "Nowy Sącz", 31, "3", "33-300", "Rynek" },
                    { 32, "7", "Tarnów", 32, "20", "33-100", "Pilźnieńska" },
                    { 33, "1", "Chorzów", 33, "9", "41-500", "Metalowa" },
                    { 34, "4", "Ruda Śląska", 34, "8", "41-700", "Śląska" },
                    { 35, "2", "Piekary Śląskie", 35, "6", "41-940", "Górka" },
                    { 36, "3", "Dąbrowa Górnicza", 36, "14", "41-300", "Przemysłowa" },
                    { 37, "6", "Jaworzno", 37, "11", "43-600", "Graniczna" },
                    { 38, "2", "Mysłowice", 38, "5", "41-400", "Miła" },
                    { 39, "4", "Tarnowskie Góry", 39, "7", "42-600", "Zamkowa" },
                    { 40, "1", "Pabianice", 40, "10", "95-200", "Fabryczna" },
                    { 41, "2", "Zamość", 41, "3", "22-400", "Hetmańska" },
                    { 42, "4", "Chełm", 42, "6", "22-100", "Dworcowa" },
                    { 43, "1", "Ełk", 43, "9", "19-300", "Mazurska" },
                    { 44, "3", "Świnoujście", 44, "2", "72-600", "Nadmorska" },
                    { 45, "5", "Kołobrzeg", 45, "15", "78-100", "Bałtycka" },
                    { 46, "2", "Puławy", 46, "7", "24-100", "Mostowa" },
                    { 47, "6", "Przemyśl", 47, "11", "37-700", "Forteczna" },
                    { 48, "4", "Krosno", 48, "8", "38-400", "Lotników" },
                    { 49, "3", "Sanok", 49, "5", "38-500", "Górska" },
                    { 50, "1", "Leszno", 50, "12", "64-100", "Kolejowa" },
                    { 51, "2", "Warszawa", 51, "3", "00-502", "Żurawia" },
                    { 52, "5", "Łódź", 52, "220", "90-001", "Piotrkowska" },
                    { 53, "1", "Gdańsk", 53, "7", "80-750", "Stoczniowa" },
                    { 54, "4", "Kraków", 54, "8", "31-019", "Floriańska" },
                    { 55, "6", "Poznań", 55, "5", "60-101", "Towarowa" },
                    { 56, "2", "Wrocław", 56, "10", "50-122", "Szewska" },
                    { 57, "3", "Szczecin", 57, "12", "70-246", "Krzywoustego" },
                    { 58, "7", "Lublin", 58, "21", "20-001", "Narutowicza" },
                    { 59, "1", "Gdynia", 59, "4", "81-372", "Świętojańska" },
                    { 60, "2", "Katowice", 60, "9", "40-001", "Kościuszki" },
                    { 61, "4", "Rzeszów", 61, "6", "35-205", "Lawendowa" },
                    { 62, "3", "Białystok", 62, "14", "15-472", "Ciepła" },
                    { 63, "5", "Opole", 63, "8", "45-760", "Wróblewskiego" },
                    { 64, "1", "Olsztyn", 64, "2", "10-436", "Dworcowa" },
                    { 65, "7", "Koszalin", 65, "18", "75-001", "Zwycięstwa" },
                    { 66, "3", "Toruń", 66, "11", "87-100", "Grudziądzka" },
                    { 67, "2", "Radom", 67, "9", "26-600", "Warszawska" },
                    { 68, "4", "Zielona Góra", 68, "7", "65-001", "Jagodowa" },
                    { 69, "5", "Legnica", 69, "12", "59-220", "Piekarska" },
                    { 70, "1", "Elbląg", 70, "5", "82-300", "Fromborska" },
                    { 71, "6", "Płock", 71, "16", "09-400", "Kasztanowa" },
                    { 72, "3", "Przemyśl", 72, "4", "37-700", "Sanowa" },
                    { 73, "2", "Ełk", 73, "10", "19-300", "Nadrzeczna" },
                    { 74, "1", "Krosno", 74, "6", "38-400", "Naftowa" },
                    { 75, "7", "Sanok", 75, "13", "38-500", "Ogrodowa" },
                    { 76, "4", "Leszno", 76, "8", "64-100", "Miła" },
                    { 77, "1", "Jaworzno", 77, "3", "43-600", "Dolna" },
                    { 78, "2", "Mysłowice", 78, "9", "41-400", "Wiosenna" },
                    { 79, "3", "Chorzów", 79, "7", "41-500", "Parkowa" },
                    { 80, "6", "Gliwice", 80, "14", "44-100", "Zielona" },
                    { 81, "2", "Tychy", 81, "5", "43-100", "Jasna" },
                    { 82, "1", "Zabrze", 82, "6", "41-800", "Łąkowa" },
                    { 83, "4", "Bytom", 83, "3", "41-902", "Krótka" },
                    { 84, "5", "Ruda Śląska", 84, "12", "41-709", "Wiejska" },
                    { 85, "3", "Tarnów", 85, "8", "33-100", "Nowa" },
                    { 86, "7", "Nowy Sącz", 86, "15", "33-300", "Południowa" },
                    { 87, "2", "Jelenia Góra", 87, "10", "58-500", "Sudecka" },
                    { 88, "1", "Wałbrzych", 88, "4", "58-300", "Sienkiewicza" },
                    { 89, "6", "Gorzów", 89, "11", "66-400", "Dworcowa" },
                    { 90, "2", "Zielona Góra", 90, "9", "65-001", "Brzozowa" },
                    { 91, "3", "Sopot", 91, "7", "81-701", "Mickiewicza" },
                    { 92, "4", "Gdynia", 92, "5", "81-522", "Orłowska" },
                    { 93, "5", "Kraków", 93, "12", "31-044", "Grodzka" },
                    { 94, "6", "Warszawa", 94, "102", "00-017", "Marszałkowska" },
                    { 95, "2", "Łódź", 95, "14", "90-113", "Sienkiewicza" },
                    { 96, "4", "Gdańsk", 96, "3", "80-819", "Okopowa" },
                    { 97, "1", "Wrocław", 97, "6", "50-001", "Kazimierza" },
                    { 98, "3", "Poznań", 98, "9", "60-776", "Śniadeckich" },
                    { 99, "2", "Katowice", 99, "8", "40-001", "Dworcowa" },
                    { 100, "5", "Lublin", 100, "7", "20-112", "Grodzka" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
