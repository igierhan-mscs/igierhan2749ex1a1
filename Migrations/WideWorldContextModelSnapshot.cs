﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using igierhan2749ex1c1.Data;

namespace igierhan2749ex1c1.Migrations
{
    [DbContext(typeof(WideWorldContext))]
    partial class WideWorldContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("igierhan2749ex1c1.Models.Cities", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LastEditedBy")
                        .HasColumnType("int");

                    b.Property<long?>("LatestRecordedPopulation")
                        .HasColumnType("bigint");

                    b.Property<int>("StateProvinceId")
                        .HasColumnType("int")
                        .HasColumnName("StateProvinceID");

                    b.HasKey("CityId");

                    b.HasIndex("StateProvinceId")
                        .HasDatabaseName("FK_Application_Cities_StateProvinceID");

                    b.ToTable("Cities", "Application");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.Countries", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CountryID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Continent")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("CountryType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FormalName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("IsoAlpha3Code")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int?>("IsoNumericCode")
                        .HasColumnType("int");

                    b.Property<int>("LastEditedBy")
                        .HasColumnType("int");

                    b.Property<long?>("LatestRecordedPopulation")
                        .HasColumnType("bigint");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Subregion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CountryId");

                    b.HasIndex("CountryName")
                        .IsUnique()
                        .HasDatabaseName("UQ_Application_Countries_CountryName");

                    b.HasIndex("FormalName")
                        .IsUnique()
                        .HasDatabaseName("UQ_Application_Countries_FormalName");

                    b.ToTable("Countries", "Application");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.CustomerCategories", b =>
                {
                    b.Property<int>("CustomerCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerCategoryID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerCategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LastEditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerCategoryId");

                    b.ToTable("CustomerCategories", "Sales");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AccountOpenedDate")
                        .HasColumnType("date");

                    b.Property<int>("AlternateContactPersonId")
                        .HasColumnType("int")
                        .HasColumnName("AlternateContactPersonID");

                    b.Property<int>("BillToCustomerId")
                        .HasColumnType("int")
                        .HasColumnName("BillToCustomerID");

                    b.Property<int>("BuyingGroupId")
                        .HasColumnType("int")
                        .HasColumnName("BuyingGroupID");

                    b.Property<decimal?>("CreditLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CustomerCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerCategoryID");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DeliveryAddressLine1")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("DeliveryAddressLine2")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("DeliveryCityId")
                        .HasColumnType("int")
                        .HasColumnName("DeliveryCityID");

                    b.Property<string>("DeliveryLocation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DeliveryMethodId")
                        .HasColumnType("int")
                        .HasColumnName("DeliveryMethodID");

                    b.Property<string>("DeliveryPostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DeliveryRun")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("FaxNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsOnCreditHold")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStatementSent")
                        .HasColumnType("bit");

                    b.Property<int>("LastEditedBy")
                        .HasColumnType("int");

                    b.Property<int>("PaymentDays")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PostalAddressLine1")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PostalAddressLine2")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("PostalCityId")
                        .HasColumnType("int")
                        .HasColumnName("PostalCityID");

                    b.Property<string>("PostalPostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("PrimaryContactPersonId")
                        .HasColumnType("int")
                        .HasColumnName("PrimaryContactPersonID");

                    b.Property<string>("RunPosition")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<decimal>("StandardDiscountPercentage")
                        .HasColumnType("decimal(18,3)");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("WebsiteURL")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("CustomerId");

                    b.HasIndex("AlternateContactPersonId");

                    b.HasIndex("CustomerCategoryId");

                    b.HasIndex("DeliveryCityId");

                    b.HasIndex("PostalCityId");

                    b.HasIndex("PrimaryContactPersonId");

                    b.ToTable("Customers", "Sales");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.People", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PersonID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomFields")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMailAddress")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FaxNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HashedPassword")
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsEmployee")
                        .HasColumnType("bit");

                    b.Property<bool>("IsExternalLogonProvider")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPermittedToLogon")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSalesperson")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSystemUser")
                        .HasColumnType("bit");

                    b.Property<int>("LastEditedBy")
                        .HasColumnType("int");

                    b.Property<string>("LogonName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PreferredName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UserPreferences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("PersonId");

                    b.ToTable("People", "Application");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.RawSqlReturn", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RawSqlReturn");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.StateProvinces", b =>
                {
                    b.Property<int>("StateProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StateProvinceID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("CountryID");

                    b.Property<int>("LastEditedBy")
                        .HasColumnType("int");

                    b.Property<long?>("LatestRecordedPopulation")
                        .HasColumnType("bigint");

                    b.Property<string>("SalesTerritory")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StateProvinceCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("StateProvinceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StateProvinceId");

                    b.HasIndex("CountryId")
                        .HasDatabaseName("FK_Application_StateProvinces_CountryID");

                    b.HasIndex("SalesTerritory")
                        .HasDatabaseName("IX_Application_StateProvinces_SalesTerritory");

                    b.HasIndex("StateProvinceName")
                        .IsUnique()
                        .HasDatabaseName("UQ_Application_StateProvinces_StateProvinceName");

                    b.ToTable("StateProvinces", "Application");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.Cities", b =>
                {
                    b.HasOne("igierhan2749ex1c1.Models.StateProvinces", "StateProvince")
                        .WithMany("Cities")
                        .HasForeignKey("StateProvinceId")
                        .HasConstraintName("FK_Application_Cities_StateProvinceID_Application_StateProvinces")
                        .IsRequired();

                    b.Navigation("StateProvince");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.Customers", b =>
                {
                    b.HasOne("igierhan2749ex1c1.Models.People", "AlternateContactPerson")
                        .WithMany("CustomersAlternateContact")
                        .HasForeignKey("AlternateContactPersonId")
                        .HasConstraintName("FK_AppPeople_SalesCustomers_AlternateContact")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("igierhan2749ex1c1.Models.CustomerCategories", "CustomerCategory")
                        .WithMany()
                        .HasForeignKey("CustomerCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("igierhan2749ex1c1.Models.Cities", "DeliveryCity")
                        .WithMany("CustomersDelivery")
                        .HasForeignKey("DeliveryCityId")
                        .HasConstraintName("FK_Sales_Cities_Sales_Customers_Delivery")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("igierhan2749ex1c1.Models.Cities", "PostalCity")
                        .WithMany("CustomersPostal")
                        .HasForeignKey("PostalCityId")
                        .HasConstraintName("FK_Sales_Cities_Sales_Customers")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("igierhan2749ex1c1.Models.People", "PrimaryContactPerson")
                        .WithMany("CustomersPrimaryContact")
                        .HasForeignKey("PrimaryContactPersonId")
                        .HasConstraintName("FK_AppPeople_SalesCustomers_PrimaryContact")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AlternateContactPerson");

                    b.Navigation("CustomerCategory");

                    b.Navigation("DeliveryCity");

                    b.Navigation("PostalCity");

                    b.Navigation("PrimaryContactPerson");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.StateProvinces", b =>
                {
                    b.HasOne("igierhan2749ex1c1.Models.Countries", "Country")
                        .WithMany("StateProvinces")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_Application_StateProvinces_CountryID_Application_Countries")
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.Cities", b =>
                {
                    b.Navigation("CustomersDelivery");

                    b.Navigation("CustomersPostal");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.Countries", b =>
                {
                    b.Navigation("StateProvinces");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.People", b =>
                {
                    b.Navigation("CustomersAlternateContact");

                    b.Navigation("CustomersPrimaryContact");
                });

            modelBuilder.Entity("igierhan2749ex1c1.Models.StateProvinces", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
