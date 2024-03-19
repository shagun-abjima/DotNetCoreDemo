﻿// <auto-generated />
using System;
using LibraryManagementSystemApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagementSystemApi.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryManagementSystemApi.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Ordered")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookCategoryId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Thomas Corman",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 100,
                            Title = "Introduction to Algorithm"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Thomas Corman",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 100,
                            Title = "Introduction to Algorithm"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Robert Sedgewick & Kevin Wayne",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 200,
                            Title = "Algorithms"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Steve Skiena",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 300,
                            Title = "The Algorithm Design Manual"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Adnan Aziz",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 400,
                            Title = "Algorithms For Interviews"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Adnan Aziz",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 400,
                            Title = "Algorithms For Interviews"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Adnan Aziz",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 400,
                            Title = "Algorithms For Interviews"
                        },
                        new
                        {
                            Id = 8,
                            Author = "George Heineman",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 500,
                            Title = "Algorithm in Nutshell"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Algorithm Design",
                            BookCategoryId = 1,
                            Ordered = false,
                            Price = 600,
                            Title = "Klienberg & Tardos"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Eric Matthes",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 700,
                            Title = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Eric Matthes",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 700,
                            Title = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Eric Matthes",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 700,
                            Title = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Paul Barry",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 800,
                            Title = "Head First Python: A Brain-Friendly Guide"
                        },
                        new
                        {
                            Id = 14,
                            Author = "Joshua Bloch",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 900,
                            Title = "Effective Java"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Joshua Bloch",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 900,
                            Title = "Effective Java"
                        },
                        new
                        {
                            Id = 16,
                            Author = "Kathy Sierra and Bert Bates",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1000,
                            Title = "Head First Java"
                        },
                        new
                        {
                            Id = 17,
                            Author = "Brian W. Kernighan, Dennis M. Ritchie",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1100,
                            Title = "C Programming Language"
                        },
                        new
                        {
                            Id = 18,
                            Author = "Brian W. Kernighan, Dennis M. Ritchie",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1100,
                            Title = "C Programming Language"
                        },
                        new
                        {
                            Id = 19,
                            Author = "Brian W. Kernighan, Dennis M. Ritchie",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1100,
                            Title = "C Programming Language"
                        },
                        new
                        {
                            Id = 20,
                            Author = "Marijn Haverbeke",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1200,
                            Title = "Eloquent JavaScript: A Modern Introduction to Programming"
                        },
                        new
                        {
                            Id = 21,
                            Author = "Donald E. Knuth",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1300,
                            Title = "The Art of Computer Programming"
                        },
                        new
                        {
                            Id = 22,
                            Author = "Donald E. Knuth",
                            BookCategoryId = 2,
                            Ordered = false,
                            Price = 1300,
                            Title = "The Art of Computer Programming"
                        },
                        new
                        {
                            Id = 23,
                            Author = "James F Kurose and Keith W Ross",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1400,
                            Title = "A Top-Down Approach: Computer Networking"
                        },
                        new
                        {
                            Id = 24,
                            Author = "Rich Seifert and James Edwards",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1500,
                            Title = "The All-New Switch Book (2nd Edition)"
                        },
                        new
                        {
                            Id = 25,
                            Author = "Rich Seifert and James Edwards",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1500,
                            Title = "The All-New Switch Book (2nd Edition)"
                        },
                        new
                        {
                            Id = 26,
                            Author = "Jerry FitzGerald, Alan Dennis, and Alexandra Durcikova",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1600,
                            Title = "Business Data Communications and Networking (14th Edition)"
                        },
                        new
                        {
                            Id = 27,
                            Author = "Forouzan",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1700,
                            Title = "Data Communications and Networking with TCP/IP Protocol Suite, 6th Edition"
                        },
                        new
                        {
                            Id = 28,
                            Author = "Gary Donahue",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1800,
                            Title = "Network Warrior, 2nd Edition"
                        },
                        new
                        {
                            Id = 29,
                            Author = "Gary Donahue",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1800,
                            Title = "Network Warrior, 2nd Edition"
                        },
                        new
                        {
                            Id = 30,
                            Author = "Gary Donahue",
                            BookCategoryId = 3,
                            Ordered = false,
                            Price = 1800,
                            Title = "Network Warrior, 2nd Edition"
                        },
                        new
                        {
                            Id = 31,
                            Author = "Ramesh Gaonkar",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 1900,
                            Title = "Microprocessor Architecture, Programming, and Applications with the 8085 (4th Edition)"
                        },
                        new
                        {
                            Id = 32,
                            Author = "Douglas V. Hall",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2000,
                            Title = "Microprocessors and Interfacing: Programming and Hardware (Hardcover)"
                        },
                        new
                        {
                            Id = 33,
                            Author = "Douglas V. Hall",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2000,
                            Title = "Microprocessors and Interfacing: Programming and Hardware (Hardcover)"
                        },
                        new
                        {
                            Id = 34,
                            Author = "Kenneth L. Short",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2100,
                            Title = "Embedded Microprocessor Systems Design"
                        },
                        new
                        {
                            Id = 35,
                            Author = "Dr. Vibhav Kumar Sachan",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2200,
                            Title = "Digital Electronics & Microprocessor"
                        },
                        new
                        {
                            Id = 36,
                            Author = "Xiaocong Fan",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2300,
                            Title = "Real-Time Embedded Systems"
                        },
                        new
                        {
                            Id = 37,
                            Author = "Jonathan A. Dell",
                            BookCategoryId = 4,
                            Ordered = false,
                            Price = 2400,
                            Title = "Digital Interface Design and Application"
                        },
                        new
                        {
                            Id = 38,
                            Author = "Shigley's Mechanical Engineering Design",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2500,
                            Title = "Richard G. Budynas and Keith J. Nisbett"
                        },
                        new
                        {
                            Id = 39,
                            Author = "Shigley's Mechanical Engineering Design",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2500,
                            Title = "Richard G. Budynas and Keith J. Nisbett"
                        },
                        new
                        {
                            Id = 40,
                            Author = "Shigley's Mechanical Engineering Design",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2500,
                            Title = "Richard G. Budynas and Keith J. Nisbett"
                        },
                        new
                        {
                            Id = 41,
                            Author = "Erik Oberg",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2600,
                            Title = "Machinery's Handbook"
                        },
                        new
                        {
                            Id = 42,
                            Author = "John J. Craig",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2700,
                            Title = "Introduction to Robotics: Mechanics and Control"
                        },
                        new
                        {
                            Id = 43,
                            Author = "Robert L. Norton",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2800,
                            Title = "Machine Design"
                        },
                        new
                        {
                            Id = 44,
                            Author = "Robert L. Norton",
                            BookCategoryId = 5,
                            Ordered = false,
                            Price = 2800,
                            Title = "Machine Design"
                        },
                        new
                        {
                            Id = 45,
                            Author = "Frank M. White",
                            BookCategoryId = 6,
                            Ordered = false,
                            Price = 3000,
                            Title = "Fluid Mechanics"
                        },
                        new
                        {
                            Id = 46,
                            Author = "Claus Borgnakke and Richard E. Sonntag",
                            BookCategoryId = 6,
                            Ordered = false,
                            Price = 3100,
                            Title = "Fundamentals of Thermodynamics"
                        },
                        new
                        {
                            Id = 47,
                            Author = "Claus Borgnakke and Richard E. Sonntag",
                            BookCategoryId = 6,
                            Ordered = false,
                            Price = 3100,
                            Title = "Fundamentals of Thermodynamics"
                        },
                        new
                        {
                            Id = 48,
                            Author = "James Stewart",
                            BookCategoryId = 7,
                            Ordered = false,
                            Price = 3200,
                            Title = "Calculus: Early Transcendentals"
                        },
                        new
                        {
                            Id = 49,
                            Author = "Mark Ryan",
                            BookCategoryId = 7,
                            Ordered = false,
                            Price = 3300,
                            Title = "Calculus for Dummies"
                        },
                        new
                        {
                            Id = 50,
                            Author = "Mark Ryan",
                            BookCategoryId = 7,
                            Ordered = false,
                            Price = 3300,
                            Title = "Calculus for Dummies"
                        },
                        new
                        {
                            Id = 51,
                            Author = "Louis Leithold",
                            BookCategoryId = 7,
                            Ordered = false,
                            Price = 3400,
                            Title = "The Calculus with Analytic Geometry"
                        },
                        new
                        {
                            Id = 52,
                            Author = "Euclid",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3500,
                            Title = "Euclid's Elements"
                        },
                        new
                        {
                            Id = 53,
                            Author = "Robert Kanigel",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3600,
                            Title = "The Man Who Knew Infinity: A Life of the Genius Ramanujan"
                        },
                        new
                        {
                            Id = 54,
                            Author = "Robert Kanigel",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3600,
                            Title = "The Man Who Knew Infinity: A Life of the Genius Ramanujan"
                        },
                        new
                        {
                            Id = 55,
                            Author = "Stephen Hawking",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3700,
                            Title = "A Brief History of Time"
                        },
                        new
                        {
                            Id = 56,
                            Author = "Albert Einstein",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800,
                            Title = "Relativity: The Special and the General Theory"
                        },
                        new
                        {
                            Id = 57,
                            Author = "Albert Einstein",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800,
                            Title = "Relativity: The Special and the General Theory"
                        },
                        new
                        {
                            Id = 58,
                            Author = "Albert Einstein",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800,
                            Title = "Relativity: The Special and the General Theory"
                        },
                        new
                        {
                            Id = 59,
                            Author = "Albert Einstein",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800,
                            Title = "Relativity: The Special and the General Theory"
                        },
                        new
                        {
                            Id = 60,
                            Author = "Albert Einstein",
                            BookCategoryId = 8,
                            Ordered = false,
                            Price = 3800,
                            Title = "Relativity: The Special and the General Theory"
                        });
                });

            modelBuilder.Entity("LibraryManagementSystemApi.Entities.BookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "computer",
                            SubCategory = "algorithm"
                        },
                        new
                        {
                            Id = 2,
                            Category = "computer",
                            SubCategory = "programming languages"
                        },
                        new
                        {
                            Id = 3,
                            Category = "computer",
                            SubCategory = "networking"
                        },
                        new
                        {
                            Id = 4,
                            Category = "computer",
                            SubCategory = "hardware"
                        },
                        new
                        {
                            Id = 5,
                            Category = "mechanical",
                            SubCategory = "machine"
                        },
                        new
                        {
                            Id = 6,
                            Category = "mechanical",
                            SubCategory = "transfer of energy"
                        },
                        new
                        {
                            Id = 7,
                            Category = "mathematics",
                            SubCategory = "calculus"
                        },
                        new
                        {
                            Id = 8,
                            Category = "mathematics",
                            SubCategory = "algebra"
                        });
                });

            modelBuilder.Entity("LibraryManagementSystemApi.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountStatus = "ACTIVE",
                            CreatedOn = new DateTime(2023, 11, 1, 13, 28, 12, 0, DateTimeKind.Unspecified),
                            Email = "an12@gmail.com",
                            FirstName = "TestF",
                            LastName = "TestL",
                            MobileNumber = "1234567891",
                            Password = "qwerty",
                            UserType = "ADMIN"
                        });
                });

            modelBuilder.Entity("LibraryManagementSystemApi.Entities.Book", b =>
                {
                    b.HasOne("LibraryManagementSystemApi.Entities.BookCategory", "BookCategory")
                        .WithMany()
                        .HasForeignKey("BookCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
