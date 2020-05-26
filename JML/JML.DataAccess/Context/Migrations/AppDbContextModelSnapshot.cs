﻿// <auto-generated />
using System;
using JML.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JML.DataAccess.Context.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JML.Domain.KnowledgeTest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiredAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TestTemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TestTemplateId");

                    b.HasIndex("UserId");

                    b.ToTable("KnowledgeTests");
                });

            modelBuilder.Entity("JML.Domain.KnowledgeTestQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsProvidedCorrectAnswer")
                        .HasColumnType("bit");

                    b.Property<Guid?>("KnowledgeTestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("QuestionTemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("KnowledgeTestId");

                    b.HasIndex("QuestionTemplateId");

                    b.ToTable("KnowledgeTestQuestions");
                });

            modelBuilder.Entity("JML.Domain.Lecture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("TimeToRead")
                        .HasColumnType("time");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Url")
                        .IsUnique();

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("JML.Domain.LectureTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LectureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.HasIndex("TagId");

                    b.ToTable("LectureTags");
                });

            modelBuilder.Entity("JML.Domain.Literature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Literature");
                });

            modelBuilder.Entity("JML.Domain.StudyGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudyGroups");
                });

            modelBuilder.Entity("JML.Domain.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("JML.Domain.Templates.AnswerTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("QuestionTemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuestionTemplateId");

                    b.ToTable("AnswerTemplates");
                });

            modelBuilder.Entity("JML.Domain.Templates.QuestionTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ControlType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TestTemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TestTemplateId");

                    b.ToTable("QuestionTemplates");
                });

            modelBuilder.Entity("JML.Domain.Templates.TestTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CountOfQuestions")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("ExecuteTime")
                        .HasColumnType("time");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestTemplates");
                });

            modelBuilder.Entity("JML.Domain.TestTemplateTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestTemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("TestTemplateId");

                    b.ToTable("TestTemplateTags");
                });

            modelBuilder.Entity("JML.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ActiveAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("AvatarBase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountOfInvalidAttempts")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("GroupId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JML.Domain.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("JML.Domain.KnowledgeTest", b =>
                {
                    b.HasOne("JML.Domain.Templates.TestTemplate", "TestTemplate")
                        .WithMany()
                        .HasForeignKey("TestTemplateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JML.Domain.User", "User")
                        .WithMany("Tests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("JML.Domain.KnowledgeTestQuestion", b =>
                {
                    b.HasOne("JML.Domain.KnowledgeTest", null)
                        .WithMany("Questions")
                        .HasForeignKey("KnowledgeTestId");

                    b.HasOne("JML.Domain.Templates.QuestionTemplate", "QuestionTemplate")
                        .WithMany()
                        .HasForeignKey("QuestionTemplateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("JML.Domain.LectureTag", b =>
                {
                    b.HasOne("JML.Domain.Lecture", "Lecture")
                        .WithMany("LectureTags")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JML.Domain.Tag", "Tag")
                        .WithMany("LectureTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("JML.Domain.Templates.AnswerTemplate", b =>
                {
                    b.HasOne("JML.Domain.Templates.QuestionTemplate", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionTemplateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("JML.Domain.Templates.QuestionTemplate", b =>
                {
                    b.HasOne("JML.Domain.Templates.TestTemplate", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestTemplateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("JML.Domain.TestTemplateTag", b =>
                {
                    b.HasOne("JML.Domain.Tag", "Tag")
                        .WithMany("TestTemplateTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JML.Domain.Templates.TestTemplate", "TestTemplate")
                        .WithMany("TestTemplateTags")
                        .HasForeignKey("TestTemplateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("JML.Domain.User", b =>
                {
                    b.HasOne("JML.Domain.StudyGroup", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("JML.Domain.UserRole", b =>
                {
                    b.HasOne("JML.Domain.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
