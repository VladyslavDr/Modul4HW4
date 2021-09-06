﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modul4HW4;

namespace Modul4HW4.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modul4HW4.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClientId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("ClientId");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            DataOfBirth = new DateTime(1998, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ivan",
                            LastName = "Ivanov",
                            PhoneNumber = "+380669785233"
                        },
                        new
                        {
                            ClientId = 2,
                            DataOfBirth = new DateTime(1999, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Max",
                            LastName = "Lisov",
                            PhoneNumber = "+380986399555"
                        },
                        new
                        {
                            ClientId = 3,
                            DataOfBirth = new DateTime(1988, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Den",
                            LastName = "Frolov",
                            PhoneNumber = "+380669558636"
                        },
                        new
                        {
                            ClientId = 4,
                            DataOfBirth = new DateTime(1960, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Egor",
                            LastName = "Demchuk",
                            PhoneNumber = "+380988884659"
                        },
                        new
                        {
                            ClientId = 5,
                            DataOfBirth = new DateTime(1996, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Vovan",
                            LastName = "Romashov",
                            PhoneNumber = "+380998696369"
                        });
                });

            modelBuilder.Entity("Modul4HW4.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<DateTime>("HiredData")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2")
                        .HasColumnName("HiredData");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DataOfBirth = new DateTime(1998, 10, 5, 5, 5, 5, 0, DateTimeKind.Unspecified),
                            FirstName = "Karl",
                            HiredData = new DateTime(2005, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Demidovich",
                            OfficeId = 1,
                            TitleId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            DataOfBirth = new DateTime(2007, 10, 5, 5, 5, 5, 0, DateTimeKind.Unspecified),
                            FirstName = "Max",
                            HiredData = new DateTime(2005, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Perkov",
                            OfficeId = 2,
                            TitleId = 3
                        },
                        new
                        {
                            EmployeeId = 3,
                            DataOfBirth = new DateTime(1998, 8, 1, 5, 5, 5, 0, DateTimeKind.Unspecified),
                            FirstName = "Olha",
                            HiredData = new DateTime(2035, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Applovna",
                            OfficeId = 4,
                            TitleId = 5
                        },
                        new
                        {
                            EmployeeId = 4,
                            DataOfBirth = new DateTime(1998, 10, 5, 5, 5, 5, 0, DateTimeKind.Unspecified),
                            FirstName = "Boria",
                            HiredData = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Pirogov",
                            OfficeId = 5,
                            TitleId = 2
                        },
                        new
                        {
                            EmployeeId = 5,
                            DataOfBirth = new DateTime(2003, 10, 5, 5, 5, 5, 0, DateTimeKind.Unspecified),
                            FirstName = "Lutik",
                            HiredData = new DateTime(2005, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Yatcuk",
                            OfficeId = 3,
                            TitleId = 1
                        });
                });

            modelBuilder.Entity("Modul4HW4.Entities.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeProjectId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("money")
                        .HasColumnName("Rate");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2")
                        .HasColumnName("StartedDate");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProject");

                    b.HasData(
                        new
                        {
                            EmployeeProjectId = 1,
                            EmployeeId = 1,
                            ProjectId = 1,
                            Rate = 5m,
                            StartedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 2,
                            EmployeeId = 2,
                            ProjectId = 2,
                            Rate = 2m,
                            StartedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 3,
                            EmployeeId = 3,
                            ProjectId = 3,
                            Rate = 3m,
                            StartedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 4,
                            EmployeeId = 4,
                            ProjectId = 4,
                            Rate = 4m,
                            StartedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 5,
                            EmployeeId = 5,
                            ProjectId = 5,
                            Rate = 5m,
                            StartedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Modul4HW4.Entities.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OfficeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Location");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Title");

                    b.HasKey("OfficeId");

                    b.ToTable("Office");

                    b.HasData(
                        new
                        {
                            OfficeId = 1,
                            Location = "London",
                            Title = "nz"
                        },
                        new
                        {
                            OfficeId = 2,
                            Location = "Germany",
                            Title = "nz"
                        },
                        new
                        {
                            OfficeId = 3,
                            Location = "Ukraine",
                            Title = "nz"
                        },
                        new
                        {
                            OfficeId = 4,
                            Location = "Poland",
                            Title = "nz"
                        },
                        new
                        {
                            OfficeId = 5,
                            Location = "Uganda",
                            Title = "nz"
                        });
                });

            modelBuilder.Entity("Modul4HW4.Entities.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Project")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BudGet")
                        .HasColumnType("money")
                        .HasColumnName("BudGet");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2")
                        .HasColumnName("StartedDate");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            BudGet = 1998.5m,
                            ClientId = 1,
                            Name = "text1",
                            StartedDate = new DateTime(2005, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 2,
                            BudGet = 100.12m,
                            ClientId = 2,
                            Name = "text2",
                            StartedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 3,
                            BudGet = 2005.8m,
                            ClientId = 3,
                            Name = "text3",
                            StartedDate = new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 4,
                            BudGet = 15.3m,
                            ClientId = 4,
                            Name = "text4",
                            StartedDate = new DateTime(2032, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 5,
                            BudGet = 200.0m,
                            ClientId = 5,
                            Name = "text5",
                            StartedDate = new DateTime(2005, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Modul4HW4.Entities.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TitleId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("TitleId");

                    b.ToTable("Title");

                    b.HasData(
                        new
                        {
                            TitleId = 1,
                            Name = "name1"
                        },
                        new
                        {
                            TitleId = 2,
                            Name = "name2"
                        },
                        new
                        {
                            TitleId = 3,
                            Name = "name3"
                        },
                        new
                        {
                            TitleId = 4,
                            Name = "name4"
                        },
                        new
                        {
                            TitleId = 5,
                            Name = "name5"
                        });
                });

            modelBuilder.Entity("Modul4HW4.Entities.Employee", b =>
                {
                    b.HasOne("Modul4HW4.Entities.Office", "Office")
                        .WithMany("Employes")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modul4HW4.Entities.Title", "Title")
                        .WithMany("Employes")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Modul4HW4.Entities.EmployeeProject", b =>
                {
                    b.HasOne("Modul4HW4.Entities.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modul4HW4.Entities.Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Modul4HW4.Entities.Project", b =>
                {
                    b.HasOne("Modul4HW4.Entities.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Modul4HW4.Entities.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Modul4HW4.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Modul4HW4.Entities.Office", b =>
                {
                    b.Navigation("Employes");
                });

            modelBuilder.Entity("Modul4HW4.Entities.Project", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Modul4HW4.Entities.Title", b =>
                {
                    b.Navigation("Employes");
                });
#pragma warning restore 612, 618
        }
    }
}
