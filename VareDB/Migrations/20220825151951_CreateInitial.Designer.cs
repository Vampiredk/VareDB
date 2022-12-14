// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VareDB.Data;

#nullable disable

namespace VareDB.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220825151951_CreateInitial")]
    partial class CreateInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VareDB.Kunde", b =>
                {
                    b.Property<int>("Kunde_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Kunde_id"), 1L, 1);

                    b.Property<string>("Addresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefonNummer")
                        .HasColumnType("int");

                    b.Property<int>("postnummer")
                        .HasColumnType("int");

                    b.HasKey("Kunde_id");

                    b.ToTable("Kunde");
                });

            modelBuilder.Entity("VareDB.Ordre", b =>
                {
                    b.Property<int>("Ordre_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ordre_id"), 1L, 1);

                    b.Property<int>("Kunde_id")
                        .HasColumnType("int");

                    b.Property<string>("Ordre_dato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ordre_id");

                    b.ToTable("Ordre");
                });

            modelBuilder.Entity("VareDB.Ordre_vare", b =>
                {
                    b.Property<int>("Ordre_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ordre_id"), 1L, 1);

                    b.Property<int>("Antal")
                        .HasColumnType("int");

                    b.Property<int>("Pris")
                        .HasColumnType("int");

                    b.Property<string>("Vare_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ordre_id");

                    b.ToTable("Ordre_vare");
                });

            modelBuilder.Entity("VareDB.Postnummer", b =>
                {
                    b.Property<int>("postnummmeer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("postnummmeer"), 1L, 1);

                    b.Property<string>("hjemby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("postnummmeer");

                    b.ToTable("Postnummer");
                });

            modelBuilder.Entity("VareDB.vare", b =>
                {
                    b.Property<int>("Vare_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Vare_id"), 1L, 1);

                    b.Property<string>("Beskrivelse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lager")
                        .HasColumnType("int");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pris")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Vare_id");

                    b.ToTable("vare");
                });

            modelBuilder.Entity("VareDB.vare_type", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Type");

                    b.ToTable("vare_Type");
                });
#pragma warning restore 612, 618
        }
    }
}
