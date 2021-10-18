﻿// <auto-generated />
using System;
using DetalleDesdeCero.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DetalleDesdeCero.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211018002649_Migracion_Inicial")]
    partial class Migracion_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("DetalleDesdeCero.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("vecesAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("PermisoId");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisoId = 1,
                            Descripcion = "Permiso para administrar el negocio",
                            Nombre = "Administrar",
                            vecesAsignado = 0
                        },
                        new
                        {
                            PermisoId = 2,
                            Descripcion = "Permiso para cobrar en caja a los clientes",
                            Nombre = "Cobrar en caja",
                            vecesAsignado = 0
                        },
                        new
                        {
                            PermisoId = 3,
                            Descripcion = "Permiso para vender y atender a los clientes",
                            Nombre = "Vender",
                            vecesAsignado = 0
                        });
                });

            modelBuilder.Entity("DetalleDesdeCero.Entidades.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("esActivo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DetalleDesdeCero.Entidades.RolesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("esAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PermisoId");

                    b.HasIndex("RolId");

                    b.ToTable("RolesDetalle");
                });

            modelBuilder.Entity("DetalleDesdeCero.Entidades.RolesDetalle", b =>
                {
                    b.HasOne("DetalleDesdeCero.Entidades.Permisos", null)
                        .WithMany("RolesDetalle")
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DetalleDesdeCero.Entidades.Roles", null)
                        .WithMany("RolesDetalle")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DetalleDesdeCero.Entidades.Permisos", b =>
                {
                    b.Navigation("RolesDetalle");
                });

            modelBuilder.Entity("DetalleDesdeCero.Entidades.Roles", b =>
                {
                    b.Navigation("RolesDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
