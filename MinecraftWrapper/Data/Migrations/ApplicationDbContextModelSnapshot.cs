﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinecraftWrapper.Data;

namespace MinecraftWrapper.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.ApplicationLog", b =>
                {
                    b.Property<Guid>("ApplicationLogId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationLogType");

                    b.Property<string>("LogText")
                        .IsRequired();

                    b.Property<DateTime>("LogTime");

                    b.Property<string>("UserId");

                    b.HasKey("ApplicationLogId");

                    b.ToTable("ApplicationLog");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Bio");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<decimal?>("CurrentMoney");

                    b.Property<string>("DiscordId")
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("GamerTag")
                        .HasMaxLength(255);

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastLoginReward");

                    b.Property<DateTime?>("LastMinecraftLogin");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<DateTime?>("MembershipExpirationTime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("Rank");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<decimal?>("Xuid")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.NewsItem", b =>
                {
                    b.Property<Guid>("NewsItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateActive");

                    b.Property<DateTime?>("DateExpires");

                    b.Property<string>("HtmlContent")
                        .IsRequired();

                    b.Property<string>("Title");

                    b.HasKey("NewsItemId");

                    b.ToTable("NewsItem");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.PlaytimeEvent", b =>
                {
                    b.Property<int>("PlaytimeEventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EventTime");

                    b.Property<string>("Type");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("PlaytimeEventId");

                    b.HasIndex("UserId");

                    b.ToTable("PlaytimeEvent");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.ScheduledTask", b =>
                {
                    b.Property<Guid>("ScheduledTaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Command")
                        .HasMaxLength(2000);

                    b.Property<string>("CronString")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("Enabled");

                    b.Property<int>("ScheduledTaskType");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ScheduledTaskId");

                    b.ToTable("ScheduledTask");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.ScheduledTaskLog", b =>
                {
                    b.Property<Guid>("ScheduledTaskLogId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CompletedTime");

                    b.Property<string>("CompletionStatus")
                        .HasMaxLength(30);

                    b.Property<Guid>("ScheduledTaskId");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("ScheduledTaskLogId");

                    b.HasIndex("ScheduledTaskId");

                    b.ToTable("ScheduledTaskLog");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.StoreItem", b =>
                {
                    b.Property<Guid>("StoreItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("Effect")
                        .HasMaxLength(450);

                    b.Property<int>("MinimumRank");

                    b.Property<decimal>("Price");

                    b.Property<bool>("RequiresLogin");

                    b.Property<int>("StoreItemTypeId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("StoreItemId");

                    b.ToTable("StoreItem");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.UserCurrency", b =>
                {
                    b.Property<Guid>("UserCurrencyId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<Guid?>("CreatedFromTransactionId");

                    b.Property<int>("CurrencyTransactionReasonId");

                    b.Property<int>("CurrencyTypeId");

                    b.Property<DateTime>("DateNoted");

                    b.Property<Guid?>("StoreItemId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("UserCurrencyId");

                    b.HasIndex("CreatedFromTransactionId");

                    b.HasIndex("StoreItemId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCurrency");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.UserPreference", b =>
                {
                    b.Property<Guid>("UserPreferenceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserId");

                    b.Property<int>("UserPreferenceType");

                    b.Property<string>("Value");

                    b.HasKey("UserPreferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPreference");
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.UtilityRequest", b =>
                {
                    b.Property<Guid>("UtilityRequestId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RequestTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<int>("UtilityRequestType");

                    b.HasKey("UtilityRequestId");

                    b.ToTable("UtilityRequest");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MinecraftWrapper.Data.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MinecraftWrapper.Data.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MinecraftWrapper.Data.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MinecraftWrapper.Data.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.PlaytimeEvent", b =>
                {
                    b.HasOne("MinecraftWrapper.Data.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.ScheduledTaskLog", b =>
                {
                    b.HasOne("MinecraftWrapper.Data.Entities.ScheduledTask", "ScheduledTask")
                        .WithMany()
                        .HasForeignKey("ScheduledTaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.UserCurrency", b =>
                {
                    b.HasOne("MinecraftWrapper.Data.Entities.UserCurrency", "CreatedFromTransaction")
                        .WithMany()
                        .HasForeignKey("CreatedFromTransactionId");

                    b.HasOne("MinecraftWrapper.Data.Entities.StoreItem", "StoreItem")
                        .WithMany()
                        .HasForeignKey("StoreItemId");

                    b.HasOne("MinecraftWrapper.Data.Entities.ApplicationUser", "User")
                        .WithMany("CurrencyLog")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MinecraftWrapper.Data.Entities.UserPreference", b =>
                {
                    b.HasOne("MinecraftWrapper.Data.Entities.ApplicationUser", "User")
                        .WithMany("UserPreferences")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
