﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace hhuMapData.Migrations
{
    [DbContext(typeof(MapDataContext))]
    [Migration("20220930060208_Markers")]
    partial class Markers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Marker", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("lat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lng")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Markers");
                });
#pragma warning restore 612, 618
        }
    }
}
