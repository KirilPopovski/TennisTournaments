﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TennisTournaments.Data;

namespace TennisTournaments.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210611152714_AddFixtures")]
    partial class AddFixtures
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TennisTournaments.Data.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Fixture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirstRegistrationId")
                        .HasColumnType("int");

                    b.Property<int>("Round")
                        .HasColumnType("int");

                    b.Property<int>("SecondRegistrationId")
                        .HasColumnType("int");

                    b.Property<int>("TournamentPlayingCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirstRegistrationId");

                    b.HasIndex("SecondRegistrationId");

                    b.HasIndex("TournamentPlayingCategoryId");

                    b.ToTable("Fixtures");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.FixtureResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FixtureId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOpponentRetired")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfSetsPlayed")
                        .HasColumnType("int");

                    b.Property<int>("WinnerRegistrationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FixtureId");

                    b.HasIndex("WinnerRegistrationId");

                    b.ToTable("FixtureResults");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.GameScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirstRegistrationPoints")
                        .HasColumnType("int");

                    b.Property<int>("FixtureId")
                        .HasColumnType("int");

                    b.Property<int>("GameNumber")
                        .HasColumnType("int");

                    b.Property<int>("SecondRegistrationPoints")
                        .HasColumnType("int");

                    b.Property<int>("SetNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FixtureId");

                    b.ToTable("GameScores");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.PlayingCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlayingCategories");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.PlayingIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RegistrationId")
                        .HasColumnType("int");

                    b.Property<int>("Seed")
                        .HasColumnType("int");

                    b.Property<int>("TournamentPlayingCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationId");

                    b.HasIndex("TournamentPlayingCategoryId");

                    b.ToTable("PlayingsIn");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.RegistrationPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("RegistrationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("RegistrationId");

                    b.ToTable("RegistrationPlayers");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.SetScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirstRegistrationGames")
                        .HasColumnType("int");

                    b.Property<int>("FixtureId")
                        .HasColumnType("int");

                    b.Property<int>("SecondRegistrationGames")
                        .HasColumnType("int");

                    b.Property<int>("SetNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FixtureId");

                    b.ToTable("SetScores");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.TieBreaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirstRegistrationPoints")
                        .HasColumnType("int");

                    b.Property<int>("FixtureId")
                        .HasColumnType("int");

                    b.Property<int>("SecondRegistrationPoints")
                        .HasColumnType("int");

                    b.Property<int>("SetNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FixtureId");

                    b.ToTable("TieBreakers");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfRounds")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SurfaceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TournamentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.TournamentPlayingCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlayingCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayingCategoryId");

                    b.HasIndex("TournamentId");

                    b.ToTable("TournamentPlayingCategories");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Fixture", b =>
                {
                    b.HasOne("TennisTournaments.Data.Models.Registration", "FirstRegistration")
                        .WithMany("FirstFixtures")
                        .HasForeignKey("FirstRegistrationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TennisTournaments.Data.Models.Registration", "SecondRegistration")
                        .WithMany("SecondFixtures")
                        .HasForeignKey("SecondRegistrationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TennisTournaments.Data.Models.TournamentPlayingCategory", "TournamentPlayingCategory")
                        .WithMany()
                        .HasForeignKey("TournamentPlayingCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirstRegistration");

                    b.Navigation("SecondRegistration");

                    b.Navigation("TournamentPlayingCategory");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.FixtureResult", b =>
                {
                    b.HasOne("TennisTournaments.Data.Models.Fixture", "Fixture")
                        .WithMany("FixtureResults")
                        .HasForeignKey("FixtureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TennisTournaments.Data.Models.Registration", "WinnerRegistration")
                        .WithMany("FixtureResults")
                        .HasForeignKey("WinnerRegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fixture");

                    b.Navigation("WinnerRegistration");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.GameScore", b =>
                {
                    b.HasOne("TennisTournaments.Data.Models.Fixture", "Fixture")
                        .WithMany("GameScores")
                        .HasForeignKey("FixtureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fixture");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Player", b =>
                {
                    b.HasOne("TennisTournaments.Data.Models.Country", "Country")
                        .WithMany("Players")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.PlayingIn", b =>
                {
                    b.HasOne("TennisTournaments.Data.Models.Registration", "Registration")
                        .WithMany("PlayingsIn")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TennisTournaments.Data.Models.TournamentPlayingCategory", "TournamentPlayingCategory")
                        .WithMany()
                        .HasForeignKey("TournamentPlayingCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");

                    b.Navigation("TournamentPlayingCategory");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.RegistrationPlayer", b =>
                {
                    b.HasOne("TennisTournaments.Data.Models.Player", "Player")
                        .WithMany("RegistrationPlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TennisTournaments.Data.Models.Registration", "Registration")
                        .WithMany("RegistrationPlayers")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.SetScore", b =>
                {
                    b.HasOne("TennisTournaments.Data.Models.Fixture", "Fixture")
                        .WithMany("SetScores")
                        .HasForeignKey("FixtureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fixture");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.TieBreaker", b =>
                {
                    b.HasOne("TennisTournaments.Data.Models.Fixture", "Fixture")
                        .WithMany("TieBreakers")
                        .HasForeignKey("FixtureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fixture");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.TournamentPlayingCategory", b =>
                {
                    b.HasOne("TennisTournaments.Data.Models.PlayingCategory", "PlayingCategory")
                        .WithMany("TournamentPlayingCategories")
                        .HasForeignKey("PlayingCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TennisTournaments.Data.Models.Tournament", "Tournament")
                        .WithMany("TournamentPlayingCategories")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlayingCategory");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Country", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Fixture", b =>
                {
                    b.Navigation("FixtureResults");

                    b.Navigation("GameScores");

                    b.Navigation("SetScores");

                    b.Navigation("TieBreakers");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Player", b =>
                {
                    b.Navigation("RegistrationPlayers");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.PlayingCategory", b =>
                {
                    b.Navigation("TournamentPlayingCategories");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Registration", b =>
                {
                    b.Navigation("FirstFixtures");

                    b.Navigation("FixtureResults");

                    b.Navigation("PlayingsIn");

                    b.Navigation("RegistrationPlayers");

                    b.Navigation("SecondFixtures");
                });

            modelBuilder.Entity("TennisTournaments.Data.Models.Tournament", b =>
                {
                    b.Navigation("TournamentPlayingCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
