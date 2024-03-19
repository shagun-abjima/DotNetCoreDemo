using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementSystemApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Ordered = table.Column<bool>(type: "bit", nullable: false),
                    BookCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_BookCategory_BookCategoryId",
                        column: x => x.BookCategoryId,
                        principalTable: "BookCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BookCategory",
                columns: new[] { "Id", "Category", "SubCategory" },
                values: new object[,]
                {
                    { 1, "computer", "algorithm" },
                    { 2, "computer", "programming languages" },
                    { 3, "computer", "networking" },
                    { 4, "computer", "hardware" },
                    { 5, "mechanical", "machine" },
                    { 6, "mechanical", "transfer of energy" },
                    { 7, "mathematics", "calculus" },
                    { 8, "mathematics", "algebra" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountStatus", "CreatedOn", "Email", "FirstName", "LastName", "MobileNumber", "Password", "UserType" },
                values: new object[] { 1, "ACTIVE", new DateTime(2023, 11, 1, 13, 28, 12, 0, DateTimeKind.Unspecified), "an12@gmail.com", "TestF", "TestL", "1234567891", "qwerty", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "BookCategoryId", "Ordered", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Thomas Corman", 1, false, 100, "Introduction to Algorithm" },
                    { 2, "Thomas Corman", 1, false, 100, "Introduction to Algorithm" },
                    { 3, "Robert Sedgewick & Kevin Wayne", 1, false, 200, "Algorithms" },
                    { 4, "Steve Skiena", 1, false, 300, "The Algorithm Design Manual" },
                    { 5, "Adnan Aziz", 1, false, 400, "Algorithms For Interviews" },
                    { 6, "Adnan Aziz", 1, false, 400, "Algorithms For Interviews" },
                    { 7, "Adnan Aziz", 1, false, 400, "Algorithms For Interviews" },
                    { 8, "George Heineman", 1, false, 500, "Algorithm in Nutshell" },
                    { 9, "Algorithm Design", 1, false, 600, "Klienberg & Tardos" },
                    { 10, "Eric Matthes", 2, false, 700, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming" },
                    { 11, "Eric Matthes", 2, false, 700, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming" },
                    { 12, "Eric Matthes", 2, false, 700, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming" },
                    { 13, "Paul Barry", 2, false, 800, "Head First Python: A Brain-Friendly Guide" },
                    { 14, "Joshua Bloch", 2, false, 900, "Effective Java" },
                    { 15, "Joshua Bloch", 2, false, 900, "Effective Java" },
                    { 16, "Kathy Sierra and Bert Bates", 2, false, 1000, "Head First Java" },
                    { 17, "Brian W. Kernighan, Dennis M. Ritchie", 2, false, 1100, "C Programming Language" },
                    { 18, "Brian W. Kernighan, Dennis M. Ritchie", 2, false, 1100, "C Programming Language" },
                    { 19, "Brian W. Kernighan, Dennis M. Ritchie", 2, false, 1100, "C Programming Language" },
                    { 20, "Marijn Haverbeke", 2, false, 1200, "Eloquent JavaScript: A Modern Introduction to Programming" },
                    { 21, "Donald E. Knuth", 2, false, 1300, "The Art of Computer Programming" },
                    { 22, "Donald E. Knuth", 2, false, 1300, "The Art of Computer Programming" },
                    { 23, "James F Kurose and Keith W Ross", 3, false, 1400, "A Top-Down Approach: Computer Networking" },
                    { 24, "Rich Seifert and James Edwards", 3, false, 1500, "The All-New Switch Book (2nd Edition)" },
                    { 25, "Rich Seifert and James Edwards", 3, false, 1500, "The All-New Switch Book (2nd Edition)" },
                    { 26, "Jerry FitzGerald, Alan Dennis, and Alexandra Durcikova", 3, false, 1600, "Business Data Communications and Networking (14th Edition)" },
                    { 27, "Forouzan", 3, false, 1700, "Data Communications and Networking with TCP/IP Protocol Suite, 6th Edition" },
                    { 28, "Gary Donahue", 3, false, 1800, "Network Warrior, 2nd Edition" },
                    { 29, "Gary Donahue", 3, false, 1800, "Network Warrior, 2nd Edition" },
                    { 30, "Gary Donahue", 3, false, 1800, "Network Warrior, 2nd Edition" },
                    { 31, "Ramesh Gaonkar", 4, false, 1900, "Microprocessor Architecture, Programming, and Applications with the 8085 (4th Edition)" },
                    { 32, "Douglas V. Hall", 4, false, 2000, "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
                    { 33, "Douglas V. Hall", 4, false, 2000, "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
                    { 34, "Kenneth L. Short", 4, false, 2100, "Embedded Microprocessor Systems Design" },
                    { 35, "Dr. Vibhav Kumar Sachan", 4, false, 2200, "Digital Electronics & Microprocessor" },
                    { 36, "Xiaocong Fan", 4, false, 2300, "Real-Time Embedded Systems" },
                    { 37, "Jonathan A. Dell", 4, false, 2400, "Digital Interface Design and Application" },
                    { 38, "Shigley's Mechanical Engineering Design", 5, false, 2500, "Richard G. Budynas and Keith J. Nisbett" },
                    { 39, "Shigley's Mechanical Engineering Design", 5, false, 2500, "Richard G. Budynas and Keith J. Nisbett" },
                    { 40, "Shigley's Mechanical Engineering Design", 5, false, 2500, "Richard G. Budynas and Keith J. Nisbett" },
                    { 41, "Erik Oberg", 5, false, 2600, "Machinery's Handbook" },
                    { 42, "John J. Craig", 5, false, 2700, "Introduction to Robotics: Mechanics and Control" },
                    { 43, "Robert L. Norton", 5, false, 2800, "Machine Design" },
                    { 44, "Robert L. Norton", 5, false, 2800, "Machine Design" },
                    { 45, "Frank M. White", 6, false, 3000, "Fluid Mechanics" },
                    { 46, "Claus Borgnakke and Richard E. Sonntag", 6, false, 3100, "Fundamentals of Thermodynamics" },
                    { 47, "Claus Borgnakke and Richard E. Sonntag", 6, false, 3100, "Fundamentals of Thermodynamics" },
                    { 48, "James Stewart", 7, false, 3200, "Calculus: Early Transcendentals" },
                    { 49, "Mark Ryan", 7, false, 3300, "Calculus for Dummies" },
                    { 50, "Mark Ryan", 7, false, 3300, "Calculus for Dummies" },
                    { 51, "Louis Leithold", 7, false, 3400, "The Calculus with Analytic Geometry" },
                    { 52, "Euclid", 8, false, 3500, "Euclid's Elements" },
                    { 53, "Robert Kanigel", 8, false, 3600, "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
                    { 54, "Robert Kanigel", 8, false, 3600, "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
                    { 55, "Stephen Hawking", 8, false, 3700, "A Brief History of Time" },
                    { 56, "Albert Einstein", 8, false, 3800, "Relativity: The Special and the General Theory" },
                    { 57, "Albert Einstein", 8, false, 3800, "Relativity: The Special and the General Theory" },
                    { 58, "Albert Einstein", 8, false, 3800, "Relativity: The Special and the General Theory" },
                    { 59, "Albert Einstein", 8, false, 3800, "Relativity: The Special and the General Theory" },
                    { 60, "Albert Einstein", 8, false, 3800, "Relativity: The Special and the General Theory" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_BookCategoryId",
                table: "Book",
                column: "BookCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "BookCategory");
        }
    }
}
