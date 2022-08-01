﻿// <auto-generated />
using System;
using Admin.Infrastucure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Admin.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Admin.Core.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Admin.Core.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("LineofBusinessId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("NationalId")
                        .HasMaxLength(14)
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("LineofBusinessId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Admin.Core.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Admin.Core.Models.Languagelevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("LanguageLevels");
                });

            modelBuilder.Entity("Admin.Core.Models.LineofBusiness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("LineofBusinesses");
                });

            modelBuilder.Entity("EmployeeLanguagelevel", b =>
                {
                    b.Property<int>("EmployeeLanguageId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeLanguageLevelId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeLanguageId", "EmployeeLanguageLevelId");

                    b.HasIndex("EmployeeLanguageLevelId");

                    b.ToTable("EmployeeLanguagelevel");
                });

            modelBuilder.Entity("Admin.Core.Models.Employee", b =>
                {
                    b.HasOne("Admin.Core.Models.Account", "Account")
                        .WithMany("Employees")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Admin.Core.Models.Language", "Language")
                        .WithMany("Employees")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Admin.Core.Models.LineofBusiness", "LineofBusiness")
                        .WithMany("Employees")
                        .HasForeignKey("LineofBusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Language");

                    b.Navigation("LineofBusiness");
                });

            modelBuilder.Entity("Admin.Core.Models.Languagelevel", b =>
                {
                    b.HasOne("Admin.Core.Models.Language", "Language")
                        .WithMany("Languagelevel")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Admin.Core.Models.LineofBusiness", b =>
                {
                    b.HasOne("Admin.Core.Models.Account", "Account")
                        .WithMany("LineofBusinesses")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("EmployeeLanguagelevel", b =>
                {
                    b.HasOne("Admin.Core.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Admin.Core.Models.Languagelevel", null)
                        .WithMany()
                        .HasForeignKey("EmployeeLanguageLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Admin.Core.Models.Account", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("LineofBusinesses");
                });

            modelBuilder.Entity("Admin.Core.Models.Language", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Languagelevel");
                });

            modelBuilder.Entity("Admin.Core.Models.LineofBusiness", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}