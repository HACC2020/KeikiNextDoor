﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OhanaSupport;

namespace OhanaSupport.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("OhanaSupport.Models.Link", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Published")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("OhanaSupport.Models.LinkTag", b =>
                {
                    b.Property<Guid>("LinkId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LinkId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("LinkTags");
                });

            modelBuilder.Entity("OhanaSupport.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("OhanaSupport.Models.LinkTag", b =>
                {
                    b.HasOne("OhanaSupport.Models.Link", "Link")
                        .WithMany("LinkTags")
                        .HasForeignKey("LinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OhanaSupport.Models.Tag", "Tag")
                        .WithMany("LinkTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Link");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("OhanaSupport.Models.Link", b =>
                {
                    b.Navigation("LinkTags");
                });

            modelBuilder.Entity("OhanaSupport.Models.Tag", b =>
                {
                    b.Navigation("LinkTags");
                });
#pragma warning restore 612, 618
        }
    }
}
