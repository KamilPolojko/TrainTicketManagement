﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainTicketManagement.Persistance;

#nullable disable

namespace TrainTicketManagement.Persistance.Migrations
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSeat")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainId");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsOccupied = true,
                            NumberOfSeat = 1,
                            StatusID = 0,
                            TrainId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsOccupied = false,
                            NumberOfSeat = 2,
                            StatusID = 0,
                            TrainId = 1
                        });
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChangeStationsSchedule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfTrainClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSeat")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<string>("TrainRelief")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TravelFinishTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TravelStartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChangeStationsSchedule = "[\"2009-01-01T00:00:00\"]",
                            NameOfTrainClass = "First",
                            NumberOfSeat = 100,
                            Price = 19.99f,
                            StatusID = 0,
                            TrainRelief = "Student",
                            TravelFinishTime = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TravelStartTime = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ChangeStationsSchedule = "[\"2007-02-03T00:00:00\"]",
                            NameOfTrainClass = "First",
                            NumberOfSeat = 120,
                            Price = 16.99f,
                            StatusID = 0,
                            TrainRelief = "Student",
                            TravelFinishTime = new DateTime(2007, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TravelStartTime = new DateTime(2007, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.Train", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BaseStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangeStations")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangesStationsSchedule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSeatsFirstClass")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeatsSecondClass")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOfCarriage")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<string>("TravelFinishTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TravelStartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("Trains");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseStation = "Warszawa",
                            ChangeStations = "[\"W\\u0142oc\\u0142awek\",\"Krak\\u00F3w\",\"Choroszcz\"]",
                            ChangesStationsSchedule = "[\"2007-02-14T00:00:00\"]",
                            Created = new DateTime(2023, 12, 23, 18, 39, 43, 609, DateTimeKind.Local).AddTicks(2152),
                            Destination = "Wroclaw",
                            NumberOfSeatsFirstClass = 150,
                            NumberOfSeatsSecondClass = 100,
                            QuantityOfCarriage = 4,
                            StatusID = 1,
                            TicketId = 0,
                            TravelFinishTime = "[\"2008-03-24T00:00:00\"]",
                            TravelStartTime = "[\"2006-01-03T00:00:00\"]"
                        });
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeselNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 12, 23, 18, 39, 43, 609, DateTimeKind.Local).AddTicks(1648),
                            DateOfBirth = new DateTime(2003, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Login = "Admin",
                            Password = "Password",
                            PeselNumber = "23234576345",
                            StatusID = 1
                        });
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.Seat", b =>
                {
                    b.HasOne("TrainTicketManagement.Domain.Entities.Train", "Train")
                        .WithMany("Seats")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Train");
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.Ticket", b =>
                {
                    b.HasOne("TrainTicketManagement.Domain.Entities.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.Train", b =>
                {
                    b.HasOne("TrainTicketManagement.Domain.Entities.Ticket", "Ticket")
                        .WithMany("Trains")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("TrainTicketManagement.Domain.ValueObjects.TrainName", "Name", b1 =>
                        {
                            b1.Property<int>("TrainId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstPartOfName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FirstPartOfTheName");

                            b1.Property<string>("SerialNumberOfTrain")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("SerialNumberOfTrain");

                            b1.HasKey("TrainId");

                            b1.ToTable("Trains");

                            b1.WithOwner()
                                .HasForeignKey("TrainId");

                            b1.HasData(
                                new
                                {
                                    TrainId = 1,
                                    FirstPartOfName = "IC",
                                    SerialNumberOfTrain = "1620"
                                });
                        });

                    b.Navigation("Name")
                        .IsRequired();

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.User", b =>
                {
                    b.OwnsOne("TrainTicketManagement.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("int");

                            b1.Property<string>("DomainName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("MailDomain");

                            b1.Property<string>("UserName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("MailName");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.HasData(
                                new
                                {
                                    UserId = 1,
                                    DomainName = "gmail.com",
                                    UserName = "janzawadzki"
                                });
                        });

                    b.OwnsOne("TrainTicketManagement.Domain.ValueObjects.PersonName", "PersonName", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("LastName");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.HasData(
                                new
                                {
                                    UserId = 1,
                                    FirstName = "Jan",
                                    LastName = "Zawadzki"
                                });
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("PersonName")
                        .IsRequired();
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.Ticket", b =>
                {
                    b.Navigation("Trains");
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.Train", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("TrainTicketManagement.Domain.Entities.User", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
