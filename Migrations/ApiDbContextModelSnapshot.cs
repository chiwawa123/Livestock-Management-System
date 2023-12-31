﻿// <auto-generated />
using System;
using LivestockMgmt.contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LivestockMgmt.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LivestockMgmt.Models.Farm", b =>
                {
                    b.Property<int>("farm_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("farm_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("district");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("country");

                    b.Property<string>("farm_description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("farm_description");

                    b.Property<string>("farm_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("farm_name");

                    b.Property<int>("farmer_id")
                        .HasColumnType("int")
                        .HasColumnName("farmer_id");

                    b.Property<string>("province")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("province");

                    b.HasKey("farm_id");

                    b.ToTable("farms");
                });

            modelBuilder.Entity("LivestockMgmt.Models.Farmer", b =>
                {
                    b.Property<int>("farmer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("farmer_id");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact_number");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("id_number")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("id_number");

                    b.Property<string>("middle_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("middle_name");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("surname");

                    b.Property<int>("user_id")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("farmer_id");

                    b.ToTable("farmers");
                });

            modelBuilder.Entity("LivestockMgmt.Models.Livestock", b =>
                {
                    b.Property<int>("stock_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("stock_id");

                    b.Property<string>("colors")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("colors");

                    b.Property<DateOnly>("dob")
                        .HasColumnType("date")
                        .HasColumnName("dob");

                    b.Property<int>("farm_id")
                        .HasColumnType("int")
                        .HasColumnName("farm_id");

                    b.Property<string>("picture_path")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("picture_path");

                    b.Property<string>("sex")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("sex");

                    b.Property<int>("stock_type_id")
                        .HasColumnType("int")
                        .HasColumnName("stock_type_id");

                    b.Property<string>("tag_number")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("tag_number");

                    b.HasKey("stock_id");

                    b.ToTable("livestocks");
                });

            modelBuilder.Entity("LivestockMgmt.Models.StockDosage", b =>
                {
                    b.Property<int>("stock_dosage_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("stock_dosage_id");

                    b.Property<DateOnly>("date_posted")
                        .HasColumnType("date")
                        .HasColumnName("date_posted");

                    b.Property<string>("dosage_description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("dosage_description");

                    b.Property<DateOnly>("expirydate")
                        .HasColumnType("date")
                        .HasColumnName("expirydate");

                    b.Property<int>("stock_id")
                        .HasColumnType("int")
                        .HasColumnName("stock_id");

                    b.HasKey("stock_dosage_id");

                    b.ToTable("stockdossages");
                });

            modelBuilder.Entity("LivestockMgmt.Models.StockState", b =>
                {
                    b.Property<int>("stock_state_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("stock_state_id");

                    b.Property<DateOnly>("created_at")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<int>("livestock_id")
                        .HasColumnType("int")
                        .HasColumnName("livestock_id");

                    b.Property<string>("state_description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("state_description");

                    b.Property<string>("stock_state")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("stock_state");

                    b.Property<DateOnly>("updated_at")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("stock_state_id");

                    b.ToTable("stockstates");
                });

            modelBuilder.Entity("LivestockMgmt.Models.StockType", b =>
                {
                    b.Property<int>("stock_type_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("stock_type_id");

                    b.Property<string>("stock_type")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("stock_type");

                    b.HasKey("stock_type_id");

                    b.ToTable("StockTypes");
                });

            modelBuilder.Entity("LivestockMgmt.Models.StockWeight", b =>
                {
                    b.Property<int>("stock_weight_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("stock_weight_id");

                    b.Property<DateOnly>("date_recorded")
                        .HasColumnType("date")
                        .HasColumnName("date_recorded");

                    b.Property<int>("stock_id")
                        .HasColumnType("int")
                        .HasColumnName("stock_id");

                    b.HasKey("stock_weight_id");

                    b.ToTable("stockweights");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
