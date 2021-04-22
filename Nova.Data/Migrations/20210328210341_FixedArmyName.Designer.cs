﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nova.Data;

namespace Nova.Data.Migrations
{
    [DbContext(typeof(NovaDbContext))]
    [Migration("20210328210341_FixedArmyName")]
    partial class FixedArmyName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nova.Data.Models.Army", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<int>("NovaModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NovaModelId");

                    b.ToTable("Armies");
                });

            modelBuilder.Entity("Nova.Data.Models.NovaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArmorPoints")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ArmorPoints");

                    b.Property<string>("AttackPoints")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AttackPoints");

                    b.Property<string>("HealethPoints")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("HealethPoints");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("NovaModels");
                });

            modelBuilder.Entity("Nova.Data.Models.Text", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Content");

                    b.Property<string>("Option")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Option");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Texts");
                });

            modelBuilder.Entity("Nova.Data.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArmyId")
                        .HasColumnType("int");

                    b.Property<int>("AttackPoints")
                        .HasColumnType("int")
                        .HasColumnName("AttackPoints");

                    b.Property<string>("HealthPoints")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("HealthPoints");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("ArmyId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Nova.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Nova.Data.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Damage")
                        .HasColumnType("int")
                        .HasColumnName("Damage");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("Nova.Data.Models.Army", b =>
                {
                    b.HasOne("Nova.Data.Models.NovaModel", "NovaModel")
                        .WithMany("Armies")
                        .HasForeignKey("NovaModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NovaModel");
                });

            modelBuilder.Entity("Nova.Data.Models.Unit", b =>
                {
                    b.HasOne("Nova.Data.Models.Army", "Army")
                        .WithMany("Units")
                        .HasForeignKey("ArmyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Army");
                });

            modelBuilder.Entity("Nova.Data.Models.Army", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("Nova.Data.Models.NovaModel", b =>
                {
                    b.Navigation("Armies");
                });
#pragma warning restore 612, 618
        }
    }
}