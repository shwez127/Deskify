﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OfficeDeskDAL.Data;

#nullable disable

namespace OfficeDeskDAL.Migrations
{
    [DbContext(typeof(DeskDbContext))]
    [Migration("20230327102219_DeskDatabase")]
    partial class DeskDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OfficeDeskEntity.Models.BookingRoom", b =>
                {
                    b.Property<int>("BookingRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingRoomId"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MeetingEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("MeetingHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeetingStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingRoomId");

                    b.HasIndex("EmployeeID");

                    b.ToTable("bookingRooms");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.BookingSeat", b =>
                {
                    b.Property<int>("BookingSeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingSeatId"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SeatShiftTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShiftEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShiftStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingSeatId");

                    b.HasIndex("EmployeeID");

                    b.ToTable("bookingSeats");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Choices", b =>
                {
                    b.Property<int>("ChoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChoiceId"));

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("FoodPerferences")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChoiceId");

                    b.HasIndex("EmployeeID");

                    b.ToTable("choices");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeNumber")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Floor", b =>
                {
                    b.Property<int>("FloorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FloorId"));

                    b.Property<string>("FloorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FloorId");

                    b.ToTable("floors");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.LoginTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("LoginTables");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.QRScanner", b =>
                {
                    b.Property<int>("QId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QId"));

                    b.Property<int>("BookingSeatId")
                        .HasColumnType("int");

                    b.Property<byte[]>("QRCode")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("QId");

                    b.HasIndex("BookingSeatId");

                    b.ToTable("qrscanners");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Receptionist", b =>
                {
                    b.Property<int>("ReceptionistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceptionistID"));

                    b.Property<string>("REmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("ReceptionistID");

                    b.HasIndex("SeatId");

                    b.ToTable("receptionists");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.ReservedRoom", b =>
                {
                    b.Property<int>("ReservedRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservedRoomId"));

                    b.Property<int>("BookingRoomId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("ReservedRoomId");

                    b.HasIndex("BookingRoomId");

                    b.HasIndex("RoomId");

                    b.ToTable("reservedRooms");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.ReservedSeat", b =>
                {
                    b.Property<int>("ReservedSeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservedSeatId"));

                    b.Property<int>("BookingSeatId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("ReservedSeatId");

                    b.HasIndex("BookingSeatId");

                    b.HasIndex("SeatId");

                    b.ToTable("reservedSeats");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"));

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.HasIndex("FloorId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatId"));

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<string>("SeatNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeatId");

                    b.HasIndex("FloorId");

                    b.ToTable("seats");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.BookingRoom", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.BookingSeat", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Choices", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Employee", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.LoginTable", "LoginTable")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoginTable");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.QRScanner", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.BookingSeat", "BookingSeat")
                        .WithMany()
                        .HasForeignKey("BookingSeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingSeat");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Receptionist", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.BookingSeat", "BookingSeat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingSeat");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.ReservedRoom", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.BookingRoom", "BookingRoom")
                        .WithMany()
                        .HasForeignKey("BookingRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OfficeDeskEntity.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingRoom");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.ReservedSeat", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.BookingSeat", "BookingSeat")
                        .WithMany()
                        .HasForeignKey("BookingSeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OfficeDeskEntity.Models.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingSeat");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Room", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.Floor", "Floor")
                        .WithMany()
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Floor");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Seat", b =>
                {
                    b.HasOne("OfficeDeskEntity.Models.Floor", "Floor")
                        .WithMany("Seats")
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Floor");
                });

            modelBuilder.Entity("OfficeDeskEntity.Models.Floor", b =>
                {
                    b.Navigation("Seats");
                });
#pragma warning restore 612, 618
        }
    }
}
