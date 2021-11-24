﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication1;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ScheduleContext))]
    [Migration("20211124124138_241121")]
    partial class _241121
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("classes", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.DaysOfWeek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("days_of_week", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("lessons", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("integer")
                        .HasColumnName("class_id");

                    b.Property<int?>("LessonId")
                        .HasColumnType("integer")
                        .HasColumnName("lesson_id");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("integer")
                        .HasColumnName("teacher_id");

                    b.Property<int?>("WeekId")
                        .HasColumnType("integer")
                        .HasColumnName("week_id");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("LessonId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("WeekId");

                    b.ToTable("schedule", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("middle_name");

                    b.HasKey("Id");

                    b.ToTable("teachers", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Schedule", b =>
                {
                    b.HasOne("WebApplication1.Models.Class", "Class")
                        .WithMany("Schedules")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("schedule_class_id_fkey");

                    b.HasOne("WebApplication1.Models.Lesson", "Lesson")
                        .WithMany("Schedules")
                        .HasForeignKey("LessonId")
                        .HasConstraintName("schedule_lesson_id_fkey");

                    b.HasOne("WebApplication1.Models.Teacher", "Teacher")
                        .WithMany("Schedules")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("schedule_teacher_id_fkey");

                    b.HasOne("WebApplication1.Models.DaysOfWeek", "Week")
                        .WithMany("Schedules")
                        .HasForeignKey("WeekId")
                        .HasConstraintName("schedule_week_id_fkey");

                    b.Navigation("Class");

                    b.Navigation("Lesson");

                    b.Navigation("Teacher");

                    b.Navigation("Week");
                });

            modelBuilder.Entity("WebApplication1.Models.Class", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("WebApplication1.Models.DaysOfWeek", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("WebApplication1.Models.Lesson", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("WebApplication1.Models.Teacher", b =>
                {
                    b.Navigation("Schedules");
                });
#pragma warning restore 612, 618
        }
    }
}
