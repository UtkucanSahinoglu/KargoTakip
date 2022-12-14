// <auto-generated />
using System;
using KargoTakip.DBBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KargoTakip.Migrations
{
    [DbContext(typeof(KargoTakipDbContext))]
    partial class KargoTakipDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Cargo.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("OpenAddress")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.ToTable("address");
                });

            modelBuilder.Entity("Cargo.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RecipientAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("RecipientName")
                        .HasColumnType("longtext");

                    b.Property<string>("SenderAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("SenderName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SendingDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TrackingNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("cargos");
                });

            modelBuilder.Entity("Cargo.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("city");
                });

            modelBuilder.Entity("Cargo.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("district");
                });

            modelBuilder.Entity("CargoTracking.CargoTracking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TrackingNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("cargoTrackings");
                });

            modelBuilder.Entity("Cargo.Address", b =>
                {
                    b.HasOne("Cargo.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cargo.District", "District")
                        .WithMany("Addresses")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("District");
                });

            modelBuilder.Entity("Cargo.Cargo", b =>
                {
                    b.HasOne("Cargo.Address", "Address")
                        .WithMany("Cargos")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Cargo.District", b =>
                {
                    b.HasOne("Cargo.City", "City")
                        .WithMany("District")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Cargo.Address", b =>
                {
                    b.Navigation("Cargos");
                });

            modelBuilder.Entity("Cargo.City", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("District");
                });

            modelBuilder.Entity("Cargo.District", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
