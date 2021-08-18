﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SHTWIMS03.Models;

namespace SHTWIMS03.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210318170720_initial")]
    partial class initial
    {
        //protected override void BuildTargetModel(ModelBuilder modelBuilder)
        protected void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SHTWIMS03.Areas.Count.Models.CountHdr", b =>
                {
                    b.Property<int>("CountHdrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CountDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LocationId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountHdrId");

                    b.ToTable("CountHdrs");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Count.Models.CountItem", b =>
                {
                    b.Property<int>("CountItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountHdrId")
                        .HasColumnType("int");

                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtyReq")
                        .HasColumnType("int");

                    b.Property<string>("UoM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountItemId");

                    b.HasIndex("CountHdrId");

                    b.ToTable("CountItems");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Locate.Models.County", b =>
                {
                    b.Property<string>("CntyFIPS")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("CntyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SeatLat")
                        .HasColumnType("float");

                    b.Property<double>("SeatLon")
                        .HasColumnType("float");

                    b.Property<string>("Territory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CntyFIPS");

                    b.ToTable("Counties");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Locate.Models.Location", b =>
                {
                    b.Property<string>("LocationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Affiliation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Agreement")
                        .HasColumnType("bit");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Climate")
                        .HasColumnType("bit");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Elev")
                        .HasColumnType("int");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<string>("LocationCounty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Lon")
                        .HasColumnType("float");

                    b.Property<string>("PhoneMain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Secure")
                        .HasColumnType("bit");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Pull.Models.CartLine", b =>
                {
                    b.Property<int>("CartLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateNeeded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PullHdrId")
                        .HasColumnType("int");

                    b.Property<int>("QtyReq")
                        .HasColumnType("int");

                    b.Property<string>("UoM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CartLineId");

                    b.HasIndex("PullHdrId");

                    b.ToTable("CartLines");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Pull.Models.PullHdr", b =>
                {
                    b.Property<int>("PullHdrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PullDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReqEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReqPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requester")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PullHdrId");

                    b.ToTable("PullHdrs");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Pull.Models.PullItem", b =>
                {
                    b.Property<int>("PullItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateNeeded")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PullHdrId")
                        .HasColumnType("int");

                    b.Property<int>("QtyReq")
                        .HasColumnType("int");

                    b.Property<int>("QtyRequested")
                        .HasColumnType("int");

                    b.Property<int>("QtyShipped")
                        .HasColumnType("int");

                    b.Property<string>("UoM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PullItemId");

                    b.HasIndex("PullHdrId");

                    b.ToTable("PullItems");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Receive.Models.ReceiveHdr", b =>
                {
                    b.Property<int>("ReceiveHdrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReceiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Receiver")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReceiveHdrId");

                    b.ToTable("ReceiveHdrs");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Receive.Models.ReceiveItem", b =>
                {
                    b.Property<int>("ReceiveItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtyReq")
                        .HasColumnType("int");

                    b.Property<int>("ReceiveHdrId")
                        .HasColumnType("int");

                    b.Property<string>("UoM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReceiveItemId");

                    b.HasIndex("ReceiveHdrId");

                    b.ToTable("ReceiveItems");
                });

            modelBuilder.Entity("SHTWIMS03.Models.CatalogItem", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UoM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("CatalogItems");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Count.Models.CountItem", b =>
                {
                    b.HasOne("SHTWIMS03.Areas.Count.Models.CountHdr", "CountHdr")
                        .WithMany("CountItems")
                        .HasForeignKey("CountHdrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CountHdr");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Pull.Models.CartLine", b =>
                {
                    b.HasOne("SHTWIMS03.Areas.Pull.Models.PullHdr", "PullHdr")
                        .WithMany()
                        .HasForeignKey("PullHdrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PullHdr");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Pull.Models.PullItem", b =>
                {
                    b.HasOne("SHTWIMS03.Areas.Pull.Models.PullHdr", "PullHdr")
                        .WithMany("PullItems")
                        .HasForeignKey("PullHdrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PullHdr");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Receive.Models.ReceiveItem", b =>
                {
                    b.HasOne("SHTWIMS03.Areas.Receive.Models.ReceiveHdr", "ReceiveHdr")
                        .WithMany("ReceiveItems")
                        .HasForeignKey("ReceiveHdrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReceiveHdr");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Count.Models.CountHdr", b =>
                {
                    b.Navigation("CountItems");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Pull.Models.PullHdr", b =>
                {
                    b.Navigation("PullItems");
                });

            modelBuilder.Entity("SHTWIMS03.Areas.Receive.Models.ReceiveHdr", b =>
                {
                    b.Navigation("ReceiveItems");
                });
#pragma warning restore 612, 618
        }
    }
}
