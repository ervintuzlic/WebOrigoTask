﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebOrigoTask.Data;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220825180658_TestMigrations3")]
    partial class TestMigrations3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("WebOrigoTask.Data.DeviceRegisterRequest", b =>
                {
                    b.Property<string>("deviceId")
                        .HasColumnType("TEXT");

                    b.Property<string>("accept")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("activationCode")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<string>("appVersion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("deviceType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("deviceId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            deviceId = "NW-H-20-0017",
                            accept = "",
                            activationCode = "XJ235IAH245D2O",
                            appVersion = "",
                            deviceType = "unset"
                        });
                });

            modelBuilder.Entity("WebOrigoTask.DeviceInfoResponse", b =>
                {
                    b.Property<string>("deviceId")
                        .HasColumnType("TEXT");

                    b.Property<string>("dateOfRegistration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("deviceOwner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("deviceOwnerDetailsbilling_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("deviceType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("leasingPeriodsComputedleasingConstructionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("leasingPeriodsleasingConstructionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("timestamp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("deviceId");

                    b.HasIndex("deviceOwnerDetailsbilling_name");

                    b.HasIndex("leasingPeriodsComputedleasingConstructionId");

                    b.HasIndex("leasingPeriodsleasingConstructionId");

                    b.ToTable("deviceInfoResponses");
                });

            modelBuilder.Entity("WebOrigoTask.DeviceOwnerDetails", b =>
                {
                    b.Property<string>("billing_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("address_city")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("address_street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("address_zip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("adress_country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("vat_number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("billing_name");

                    b.ToTable("DeviceOwnerDetails");
                });

            modelBuilder.Entity("WebOrigoTask.ErrorResponse", b =>
                {
                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("title");

                    b.ToTable("errorResponses");
                });

            modelBuilder.Entity("WebOrigoTask.LeasingPeriods", b =>
                {
                    b.Property<int>("leasingConstructionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("leasingConstructionMaximumDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("leasingConstructionMaximumTraining")
                        .HasColumnType("INTEGER");

                    b.HasKey("leasingConstructionId");

                    b.ToTable("LeasingPeriods");
                });

            modelBuilder.Entity("WebOrigoTask.LeasingPeriodsComputed", b =>
                {
                    b.Property<int>("leasingConstructionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("leasingActualPeriodStartDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("leasingConstructionMaximumDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("leasingConstructionMaximumTraining")
                        .HasColumnType("INTEGER");

                    b.Property<string>("leasingNextCheck")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("leasingConstructionId");

                    b.ToTable("LeasingPeriodsComputeds");
                });

            modelBuilder.Entity("WebOrigoTask.LeasingUpdateRequest", b =>
                {
                    b.Property<string>("deviceId")
                        .HasColumnType("TEXT");

                    b.Property<int>("deviceTrainings")
                        .HasColumnType("INTEGER");

                    b.HasKey("deviceId");

                    b.ToTable("leasingUpdateRequests");
                });

            modelBuilder.Entity("WebOrigoTask.DeviceInfoResponse", b =>
                {
                    b.HasOne("WebOrigoTask.DeviceOwnerDetails", "deviceOwnerDetails")
                        .WithMany()
                        .HasForeignKey("deviceOwnerDetailsbilling_name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebOrigoTask.LeasingPeriodsComputed", "leasingPeriodsComputed")
                        .WithMany()
                        .HasForeignKey("leasingPeriodsComputedleasingConstructionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebOrigoTask.LeasingPeriods", "leasingPeriods")
                        .WithMany()
                        .HasForeignKey("leasingPeriodsleasingConstructionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("deviceOwnerDetails");

                    b.Navigation("leasingPeriods");

                    b.Navigation("leasingPeriodsComputed");
                });
#pragma warning restore 612, 618
        }
    }
}
