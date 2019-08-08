﻿// <auto-generated />
using System;
using BankingPoker_BackEnd.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankingPoker_BackEnd.Migrations
{
    [DbContext(typeof(BankPokerDbContext))]
    partial class BankPokerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankingPoker_BackEnd.Entity.BuyInDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumberAdd");

                    b.Property<Guid>("PlayerId");

                    b.Property<DateTime>("TimeAdd");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("BuyInDetail");
                });

            modelBuilder.Entity("BankingPoker_BackEnd.Entity.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("BankingPoker_BackEnd.Entity.Sumary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("PlayerId");

                    b.Property<int>("Profit");

                    b.Property<int>("SumAdd");

                    b.Property<int>("SumCutOut");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Sumary");
                });

            modelBuilder.Entity("BankingPoker_BackEnd.Entity.BuyInDetail", b =>
                {
                    b.HasOne("BankingPoker_BackEnd.Entity.Player", "Player")
                        .WithMany("BuyInDetails")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BankingPoker_BackEnd.Entity.Sumary", b =>
                {
                    b.HasOne("BankingPoker_BackEnd.Entity.Player", "Player")
                        .WithMany("Sumaries")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
