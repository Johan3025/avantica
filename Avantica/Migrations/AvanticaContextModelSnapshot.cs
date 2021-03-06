﻿// <auto-generated />
using System;
using Avantica.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Avantica.Migrations
{
    [DbContext(typeof(AvanticaContext))]
    partial class AvanticaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Avantica.Models.Properties", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Gross_Yield")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("List_Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Monthly_Rent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year_Built")
                        .HasColumnType("int");

                    b.HasKey("Address");

                    b.ToTable("Properties","dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
