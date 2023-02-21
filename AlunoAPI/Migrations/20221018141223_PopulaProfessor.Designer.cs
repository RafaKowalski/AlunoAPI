﻿// <auto-generated />
using AlunoAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlunoAPI.Migrations
{
    [DbContext(typeof(AlunoDbContext))]
    [Migration("20221018141223_PopulaProfessor")]
    partial class PopulaProfessor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AlunoAPI.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("AlunoId");

                    b.HasIndex("SalaId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("AlunoAPI.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ProfessorId");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("AlunoAPI.Models.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Letra")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.HasKey("SalaId");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("AlunoAPI.Models.Aluno", b =>
                {
                    b.HasOne("AlunoAPI.Models.Sala", "Sala")
                        .WithMany("Alunos")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("AlunoAPI.Models.Sala", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}