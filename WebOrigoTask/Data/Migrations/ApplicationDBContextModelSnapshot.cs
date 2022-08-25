﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebOrigoTask.Data;

#nullable disable

namespace WebOrigoTask.Data.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Devices", (string)null);

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

                    b.Property<string>("deviceOwnerDetailsdeviceId")
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

                    b.HasIndex("deviceOwnerDetailsdeviceId");

                    b.HasIndex("leasingPeriodsComputedleasingConstructionId");

                    b.HasIndex("leasingPeriodsleasingConstructionId");

                    b.ToTable("deviceInfoResponses", (string)null);
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

                    b.ToTable("DeviceOwnerDetails", (string)null);
                });

            modelBuilder.Entity("WebOrigoTask.ErrorResponse", b =>
                {
                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("title");

                    b.ToTable("errorResponses", (string)null);
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

                    b.ToTable("LeasingPeriods", (string)null);
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

                    b.ToTable("LeasingPeriodsComputeds", (string)null);
                });

            modelBuilder.Entity("WebOrigoTask.DeviceInfoResponse", b =>
                {
                    b.HasOne("WebOrigoTask.DeviceInfoResponse", "deviceOwnerDetails")
                        .WithMany()
                        .HasForeignKey("deviceOwnerDetailsdeviceId");

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
