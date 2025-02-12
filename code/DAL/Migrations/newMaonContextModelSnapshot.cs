﻿// <auto-generated />
using System;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(newMaonContext))]
    partial class newMaonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Hebrew_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.models.ActivityUpdate", b =>
                {
                    b.Property<int>("IdActivityUpdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdActivityUpdate")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId")
                        .HasColumnType("int")
                        .HasColumnName("ClassId");

                    b.Property<DateTime>("DailyActivityDate")
                        .HasColumnType("datetime")
                        .HasColumnName("DailyActivityDate");

                    b.Property<string>("DailyActivityInfo")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("DailyActivityInfo");

                    b.Property<string>("DailyActivitySubject")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("DailyActivitySubject");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("TeacherId");

                    b.HasKey("IdActivityUpdate")
                        .HasName("PK__Activity__BF62B0120F430C85");

                    b.HasIndex("ClassId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ActivityUpdate");
                });

            modelBuilder.Entity("DAL.models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClassId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("ClassName");

                    b.Property<int>("ClassTypeId")
                        .HasColumnType("int")
                        .HasColumnName("ClassTypeId");

                    b.HasKey("ClassId")
                        .HasName("PK__Classes__BF62B0120F430C85");

                    b.HasIndex("ClassTypeId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("DAL.models.DayCare", b =>
                {
                    b.Property<int>("IdDayCare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdDayCare")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BehaviorDayCare")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("BehaviorDayCare");

                    b.Property<string>("CommentDayCare")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("CommentDayCare");

                    b.Property<DateTime>("DateCare")
                        .HasColumnType("datetime")
                        .HasColumnName("DateCare");

                    b.Property<string>("DressDayCare")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("DressDayCare");

                    b.Property<string>("FoodDayCare")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("FoodDayCare");

                    b.Property<int>("KidId")
                        .HasColumnType("int")
                        .HasColumnName("KidId");

                    b.Property<string>("SleepDayCare")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("SleepDayCare");

                    b.HasKey("IdDayCare")
                        .HasName("PK__day_care__3DDF0F6C2DFCB989");

                    b.HasIndex("KidId");

                    b.ToTable("DayCare");
                });

            modelBuilder.Entity("DAL.models.ExternalData", b =>
                {
                    b.Property<int>("ExternalDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ExternalDataId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId")
                        .HasColumnType("int")
                        .HasColumnName("ClassId");

                    b.Property<DateTime>("ExternalDataDate")
                        .HasColumnType("datetime")
                        .HasColumnName("ExternalDataDate");

                    b.Property<string>("ExternalDataLink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("ExternalDataLink");

                    b.Property<string>("ExternalDataTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("ExternalDataTitle");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("TeacherId");

                    b.HasKey("ExternalDataId")
                        .HasName("PK__externaldata__5234F2D4EE33DA1B");

                    b.HasIndex("ClassId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ExternalData");
                });

            modelBuilder.Entity("DAL.models.Images", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ImageId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId")
                        .HasColumnType("int")
                        .HasColumnName("ClassId");

                    b.Property<string>("ImageData")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("ImageData");

                    b.Property<DateTime>("ImageDate")
                        .HasColumnType("datetime")
                        .HasColumnName("ImageDate");

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("ImageTitle");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("ImageURL");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("TeacherId");

                    b.HasKey("ImageId")
                        .HasName("PK__image__5234F2D4EE33DA1B");

                    b.HasIndex("ClassId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DAL.models.Kid", b =>
                {
                    b.Property<int>("KidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KidId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AgeKids")
                        .HasColumnType("float")
                        .HasColumnName("AgeKid");

                    b.Property<int>("ClassId")
                        .HasColumnType("int")
                        .HasColumnName("ClassId");

                    b.Property<DateTime>("DateBorn")
                        .HasColumnType("datetime")
                        .HasColumnName("DateBorn");

                    b.Property<string>("NameKids")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("NameKid");

                    b.Property<int>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("ParentId");

                    b.Property<string>("TzKid")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("TzKid");

                    b.HasKey("KidId")
                        .HasName("PK__kids__FB5DFF00013EE552");

                    b.HasIndex("ClassId");

                    b.HasIndex("ParentId");

                    b.ToTable("Kids");
                });

            modelBuilder.Entity("DAL.models.KidsAttendance", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AttendanceId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CurrentDate")
                        .HasColumnType("datetime")
                        .HasColumnName("CurrentDate");

                    b.Property<bool>("IsArrived")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("IsArrived");

                    b.Property<int>("KidId")
                        .HasColumnType("int")
                        .HasColumnName("KidId");

                    b.HasKey("AttendanceId")
                        .HasName("PK__kids_att__20D6A96841C11ED2");

                    b.HasIndex("KidId");

                    b.ToTable("KidsAttendance");
                });

            modelBuilder.Entity("DAL.models.Messages", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MessageId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KidId")
                        .HasColumnType("int")
                        .HasColumnName("KidId");

                    b.Property<string>("MessageContent")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("MessageContent");

                    b.Property<DateTime>("MessageDateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("MessageDateTime");

                    b.Property<int>("UserFromId")
                        .HasColumnType("int")
                        .HasColumnName("UserFromId");

                    b.Property<int>("UserToId")
                        .HasColumnType("int")
                        .HasColumnName("UserToId");

                    b.HasKey("MessageId")
                        .HasName("PK__message__3DDF0F6C2DFCB989");

                    b.HasIndex("KidId");

                    b.HasIndex("UserFromId");

                    b.HasIndex("UserToId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DAL.models.PlacementOfATeacher", b =>
                {
                    b.Property<int>("IdPlacementOfATeacher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPlacementOfATeacher")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DayInWeek1A")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek1A");

                    b.Property<int?>("DayInWeek1M")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek1M");

                    b.Property<int?>("DayInWeek2A")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek2A");

                    b.Property<int?>("DayInWeek2M")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek2M");

                    b.Property<int?>("DayInWeek3A")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek3A");

                    b.Property<int?>("DayInWeek3M")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek3M");

                    b.Property<int?>("DayInWeek4A")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek4A");

                    b.Property<int?>("DayInWeek4M")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek4M");

                    b.Property<int?>("DayInWeek5A")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek5A");

                    b.Property<int?>("DayInWeek5M")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek5M");

                    b.Property<int?>("DayInWeek6M")
                        .HasColumnType("int")
                        .HasColumnName("DayInWeek6M");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("TeacherId");

                    b.HasKey("IdPlacementOfATeacher")
                        .HasName("PK__placemen__EC1AB144B1E88409");

                    b.HasIndex("TeacherId");

                    b.ToTable("PlacementOfATeacher");
                });

            modelBuilder.Entity("DAL.models.RecoverLosts", b =>
                {
                    b.Property<int>("RecoverLostsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RecoverLostsId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUser")
                        .HasColumnType("int")
                        .HasColumnName("IdUser");

                    b.Property<DateTime>("RecoverLostsDate")
                        .HasColumnType("datetime")
                        .HasColumnName("RecoverLostsDate");

                    b.Property<string>("RecoverLostsImage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("RecoverLostsImage");

                    b.Property<string>("RecoverLostsInfo")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("RecoverLostsInfo");

                    b.HasKey("RecoverLostsId")
                        .HasName("PK__rec__5234F2D4EE33DA1B");

                    b.HasIndex("IdUser");

                    b.ToTable("RecoverLosts");
                });

            modelBuilder.Entity("DAL.models.TypeClass", b =>
                {
                    b.Property<int>("IdTypeClass")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTypeClass")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeClassName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TypeClassName");

                    b.HasKey("IdTypeClass")
                        .HasName("PK__type_cla__D21A678A5C59ED67");

                    b.ToTable("TypeClass");
                });

            modelBuilder.Entity("DAL.models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("Address");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int")
                        .HasColumnName("ClassId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Password");

                    b.Property<string>("PhoneNamber1")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("PhoneNamber1");

                    b.Property<string>("PhoneNamber2")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("PhoneNamber2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("UserName");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int")
                        .HasColumnName("UserTypeId");

                    b.Property<string>("UserTz")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("UserTz");

                    b.HasKey("UserId")
                        .HasName("PK__user__54384119BEE1AB93");

                    b.HasIndex("ClassId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.models.ActivityUpdate", b =>
                {
                    b.HasOne("DAL.models.Class", "Class")
                        .WithMany("ActivityUpdates")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__Activity___class__6B24EA82");

                    b.HasOne("DAL.models.User", "UserTeacher")
                        .WithMany("ActivityUpdates")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK__Activity___teacher__6C190EBB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("UserTeacher");
                });

            modelBuilder.Entity("DAL.models.Class", b =>
                {
                    b.HasOne("DAL.models.TypeClass", "TypeClass")
                        .WithMany("Class")
                        .HasForeignKey("ClassTypeId")
                        .HasConstraintName("FK__class_type__6C190EBB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeClass");
                });

            modelBuilder.Entity("DAL.models.DayCare", b =>
                {
                    b.HasOne("DAL.models.Kid", "Kid")
                        .WithMany("DayCare")
                        .HasForeignKey("KidId")
                        .HasConstraintName("FK__Activity___KidId__6C190EBB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kid");
                });

            modelBuilder.Entity("DAL.models.ExternalData", b =>
                {
                    b.HasOne("DAL.models.Class", "Class")
                        .WithMany("ExternalData")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__ext__class___5DCAEF64");

                    b.HasOne("DAL.models.User", "UserTeacher")
                        .WithMany("ExternalData")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK__ext__user___5DCAEF64")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("UserTeacher");
                });

            modelBuilder.Entity("DAL.models.Images", b =>
                {
                    b.HasOne("DAL.models.Class", "Class")
                        .WithMany("Images")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__images__class___5DCAEF64");

                    b.HasOne("DAL.models.User", "UserTeacher")
                        .WithMany("Images")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK__images__user___5DCAEF64")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("UserTeacher");
                });

            modelBuilder.Entity("DAL.models.Kid", b =>
                {
                    b.HasOne("DAL.models.Class", "Class")
                        .WithMany("Kids")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__kids__class_id__60A75C0F")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.models.User", "UserParent")
                        .WithMany("Kids")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("FK__kids__parents_id__619B8048")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("UserParent");
                });

            modelBuilder.Entity("DAL.models.KidsAttendance", b =>
                {
                    b.HasOne("DAL.models.Kid", "Kid")
                        .WithMany("KidsAttendance")
                        .HasForeignKey("KidId")
                        .HasConstraintName("FK__kids__attendance__619B8048")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kid");
                });

            modelBuilder.Entity("DAL.models.Messages", b =>
                {
                    b.HasOne("DAL.models.Kid", "Kid")
                        .WithMany("Messages")
                        .HasForeignKey("KidId")
                        .HasConstraintName("FK__Activity___Kid_message__6C190EBB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.models.User", "UserFrom")
                        .WithMany("MessagesFrom")
                        .HasForeignKey("UserFromId")
                        .HasConstraintName("FK__Activity___userfrom__6C190EBB")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.models.User", "UserTo")
                        .WithMany("MessagesTo")
                        .HasForeignKey("UserToId")
                        .HasConstraintName("FK__Activity___userto__6C190EBC")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Kid");

                    b.Navigation("UserFrom");

                    b.Navigation("UserTo");
                });

            modelBuilder.Entity("DAL.models.PlacementOfATeacher", b =>
                {
                    b.HasOne("DAL.models.User", "UserTeacher")
                        .WithMany("PlacementOfATeacher")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK__placement__teach__68487DD7")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserTeacher");
                });

            modelBuilder.Entity("DAL.models.RecoverLosts", b =>
                {
                    b.HasOne("DAL.models.User", "User")
                        .WithMany("RecoverLosts")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FK__rec__user___5DCAEF64")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.models.User", b =>
                {
                    b.HasOne("DAL.models.Class", "Class")
                        .WithMany("TeacherUsers")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__exte__class___5DCAEF64");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("DAL.models.Class", b =>
                {
                    b.Navigation("ActivityUpdates");

                    b.Navigation("ExternalData");

                    b.Navigation("Images");

                    b.Navigation("Kids");

                    b.Navigation("TeacherUsers");
                });

            modelBuilder.Entity("DAL.models.Kid", b =>
                {
                    b.Navigation("DayCare");

                    b.Navigation("KidsAttendance");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("DAL.models.TypeClass", b =>
                {
                    b.Navigation("Class");
                });

            modelBuilder.Entity("DAL.models.User", b =>
                {
                    b.Navigation("ActivityUpdates");

                    b.Navigation("ExternalData");

                    b.Navigation("Images");

                    b.Navigation("Kids");

                    b.Navigation("MessagesFrom");

                    b.Navigation("MessagesTo");

                    b.Navigation("PlacementOfATeacher");

                    b.Navigation("RecoverLosts");
                });
#pragma warning restore 612, 618
        }
    }
}
