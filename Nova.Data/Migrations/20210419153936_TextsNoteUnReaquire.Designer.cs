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
    [Migration("20210419153936_TextsNoteUnReaquire")]
    partial class TextsNoteUnReaquire
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
                        .HasColumnType("nvarchar(max)")
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

                    b.Property<int>("ArmorPoints")
                        .HasColumnType("int")
                        .HasColumnName("ArmorPoints");

                    b.Property<int>("AttackPoints")
                        .HasColumnType("int")
                        .HasColumnName("AttackPoints");

                    b.Property<int>("HealthPoints")
                        .HasColumnType("int")
                        .HasColumnName("HealthPoints");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("Range")
                        .HasColumnType("int")
                        .HasColumnName("Range");

                    b.HasKey("Id");

                    b.ToTable("NovaModels");
                });

            modelBuilder.Entity("Nova.Data.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.Property<int>("TextId")
                        .HasColumnType("int")
                        .HasColumnName("TextId");

                    b.HasKey("Id");

                    b.HasIndex("TextId");

                    b.ToTable("Options");
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

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImgUrl");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Note");

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

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HealthPoints")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("HealthPoints");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("Range")
                        .HasColumnType("int")
                        .HasColumnName("Range");

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

                    b.Property<int>("Armor")
                        .HasColumnType("int")
                        .HasColumnName("Armor");

                    b.Property<int>("Damage")
                        .HasColumnType("int")
                        .HasColumnName("Damage");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("NovaModelId")
                        .HasColumnType("int");

                    b.Property<int>("Range")
                        .HasColumnType("int")
                        .HasColumnName("Range");

                    b.HasKey("Id");

                    b.HasIndex("NovaModelId");

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

            modelBuilder.Entity("Nova.Data.Models.Option", b =>
                {
                    b.HasOne("Nova.Data.Models.Text", "Text")
                        .WithMany("Options")
                        .HasForeignKey("TextId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Text");
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

            modelBuilder.Entity("Nova.Data.Models.Weapon", b =>
                {
                    b.HasOne("Nova.Data.Models.NovaModel", "NovaModel")
                        .WithMany("Weapons")
                        .HasForeignKey("NovaModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NovaModel");
                });

            modelBuilder.Entity("Nova.Data.Models.Army", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("Nova.Data.Models.NovaModel", b =>
                {
                    b.Navigation("Armies");

                    b.Navigation("Weapons");
                });

            modelBuilder.Entity("Nova.Data.Models.Text", b =>
                {
                    b.Navigation("Options");
                });
#pragma warning restore 612, 618
        }
    }
}
