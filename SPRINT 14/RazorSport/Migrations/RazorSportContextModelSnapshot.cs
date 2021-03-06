// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorSport.Data;

namespace RazorSport.Migrations
{
    [DbContext(typeof(RazorSportContext))]
    partial class RazorSportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("RazorSport.Models.Atleet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Geboortedatum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Naam")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nationaliteit")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Atleet");
                });
#pragma warning restore 612, 618
        }
    }
}
