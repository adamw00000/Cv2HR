﻿// <auto-generated />
using System;
using CV2HR.EF_Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CV2HR.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CV2HR.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CV2HR.Models.JobApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ContactAgreement");

                    b.Property<string>("CvUri");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("OfferId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.ToTable("JobApplications");
                });

            modelBuilder.Entity("CV2HR.Models.JobOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("JobTitle")
                        .IsRequired();

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<decimal?>("SalaryFrom");

                    b.Property<decimal?>("SalaryTo");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<DateTime?>("ValidUntil");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobTitle");

                    b.ToTable("JobOffers");
                });

            modelBuilder.Entity("CV2HR.Models.JobApplication", b =>
                {
                    b.HasOne("CV2HR.Models.JobOffer", "Offer")
                        .WithMany("JobApplications")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CV2HR.Models.JobOffer", b =>
                {
                    b.HasOne("CV2HR.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
