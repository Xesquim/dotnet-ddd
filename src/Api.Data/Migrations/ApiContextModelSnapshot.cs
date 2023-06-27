﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.Domain.Entities.CityEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnName("create_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("IbgeCode")
                        .HasColumnName("ibge_code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<Guid>("SiId")
                        .HasColumnName("si_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnName("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("pk_city_entity");

                    b.HasIndex("IbgeCode")
                        .HasName("ix_city_ibge_code");

                    b.HasIndex("SiId")
                        .HasName("ix_city_entity_si_id");

                    b.ToTable("city");
                });

            modelBuilder.Entity("Api.Domain.Entities.SiEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnName("abbreviation")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnName("create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnName("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("pk_si_entity");

                    b.HasIndex("Abbreviation")
                        .IsUnique()
                        .HasName("ix_si_abbreviation");

                    b.ToTable("si");

                    b.HasData(
                        new
                        {
                            Id = new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                            Abbreviation = "AC",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6899),
                            Name = "Acre"
                        },
                        new
                        {
                            Id = new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                            Abbreviation = "AL",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6950),
                            Name = "Alagoas"
                        },
                        new
                        {
                            Id = new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                            Abbreviation = "AM",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6953),
                            Name = "Amazonas"
                        },
                        new
                        {
                            Id = new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                            Abbreviation = "AP",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6956),
                            Name = "Amapá"
                        },
                        new
                        {
                            Id = new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                            Abbreviation = "BA",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6958),
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                            Abbreviation = "CE",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6960),
                            Name = "Ceará"
                        },
                        new
                        {
                            Id = new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                            Abbreviation = "DF",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6962),
                            Name = "Distrito Federal"
                        },
                        new
                        {
                            Id = new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                            Abbreviation = "ES",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6964),
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            Id = new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                            Abbreviation = "GO",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6966),
                            Name = "Goiás"
                        },
                        new
                        {
                            Id = new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                            Abbreviation = "MA",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6968),
                            Name = "Maranhão"
                        },
                        new
                        {
                            Id = new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                            Abbreviation = "MG",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6970),
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                            Abbreviation = "MS",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6972),
                            Name = "Mato Grosso do Sul"
                        },
                        new
                        {
                            Id = new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                            Abbreviation = "MT",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6973),
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            Id = new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                            Abbreviation = "PA",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6975),
                            Name = "Pará"
                        },
                        new
                        {
                            Id = new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                            Abbreviation = "PB",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6977),
                            Name = "Paraíba"
                        },
                        new
                        {
                            Id = new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                            Abbreviation = "PE",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6978),
                            Name = "Pernambuco"
                        },
                        new
                        {
                            Id = new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                            Abbreviation = "PI",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6980),
                            Name = "Piauí"
                        },
                        new
                        {
                            Id = new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                            Abbreviation = "PR",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6982),
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                            Abbreviation = "RJ",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6984),
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                            Abbreviation = "RN",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6986),
                            Name = "Rio Grande do Norte"
                        },
                        new
                        {
                            Id = new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                            Abbreviation = "RO",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6988),
                            Name = "Rondônia"
                        },
                        new
                        {
                            Id = new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                            Abbreviation = "RR",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6990),
                            Name = "Roraima"
                        },
                        new
                        {
                            Id = new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                            Abbreviation = "RS",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6991),
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                            Abbreviation = "SC",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6993),
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Id = new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                            Abbreviation = "SE",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6995),
                            Name = "Sergipe"
                        },
                        new
                        {
                            Id = new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                            Abbreviation = "SP",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6997),
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                            Abbreviation = "TO",
                            CreateAt = new DateTime(2023, 6, 27, 4, 5, 40, 72, DateTimeKind.Utc).AddTicks(6999),
                            Name = "Tocantins"
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .IsRequired()
                        .HasColumnName("create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnName("update_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnName("user_name")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasName("ix_user_email");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasName("ix_user_user_name");

                    b.ToTable("user");

                    b.HasData(
                        new
                        {
                            Id = new Guid("444f5399-3051-44fd-a5b9-255b84a4eb3d"),
                            CreateAt = new DateTime(2023, 6, 27, 1, 5, 39, 949, DateTimeKind.Local).AddTicks(203),
                            Email = "admin@test.com",
                            Password = "$2a$11$3w8lcGkBoiMT2wUn7V2G.uzKLuuNcKQON4WP.N5BoZQ5Tzu1sA7XO",
                            UpdateAt = new DateTime(2023, 6, 27, 1, 5, 39, 949, DateTimeKind.Local).AddTicks(9888),
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.ZipCodeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnName("city_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnName("create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .HasColumnName("number")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnName("street")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnName("update_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnName("zip_code")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id")
                        .HasName("pk_zip_code_entity");

                    b.HasIndex("CityId")
                        .HasName("ix_zip_code_entity_city_id");

                    b.HasIndex("ZipCode")
                        .HasName("ix_zip_code_zip_code");

                    b.ToTable("zip_code");
                });

            modelBuilder.Entity("Api.Domain.Entities.CityEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.SiEntity", "Si")
                        .WithMany("Cities")
                        .HasForeignKey("SiId")
                        .HasConstraintName("fk_city_entity_si_entity_si_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api.Domain.Entities.ZipCodeEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.CityEntity", "City")
                        .WithMany("ZipCodes")
                        .HasForeignKey("CityId")
                        .HasConstraintName("fk_zip_code_entity_city_entity_city_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
