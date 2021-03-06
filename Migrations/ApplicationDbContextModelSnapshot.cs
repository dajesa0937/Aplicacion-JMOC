// <auto-generated />
using System;
using AppSenaJmoc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppSenaJmoc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppSenaJmoc.Models.Cliente", b =>
                {
                    b.Property<int>("Id_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos_Cliente")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ciudad_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Cliente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Detalle_factura", b =>
                {
                    b.Property<int>("Id_Detalle_factura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cantidad_Detalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Materiales")
                        .HasColumnType("int");

                    b.HasKey("Id_Detalle_factura");

                    b.HasIndex("Id_Materiales");

                    b.ToTable("detalle_Facturas");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Detalle_presupuesto", b =>
                {
                    b.Property<int>("Id_detalle_Presupuesto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad_detalle_Presupuesto")
                        .HasColumnType("int");

                    b.Property<int>("Id_Materiales")
                        .HasColumnType("int");

                    b.HasKey("Id_detalle_Presupuesto");

                    b.HasIndex("Id_Materiales");

                    b.ToTable("detalle_Presupuestos");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Equipo", b =>
                {
                    b.Property<int>("Id_Equipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<string>("Marca_Equipo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Serie_Equipo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Tipo_Cliente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Equipo");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Factura", b =>
                {
                    b.Property<int>("Id_factura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Detalle_factura")
                        .HasColumnType("int");

                    b.Property<int>("Id_Equipo")
                        .HasColumnType("int");

                    b.Property<int>("Id_Tecnico")
                        .HasColumnType("int");

                    b.Property<string>("Total_pagar_factura")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_factura");

                    b.HasIndex("Id_Detalle_factura");

                    b.HasIndex("Id_Equipo");

                    b.HasIndex("Id_Tecnico");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Materiales", b =>
                {
                    b.Property<int>("Id_Materiales")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion_materiales")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Existencias_Materiales")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("Id_Proveedor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Materiales")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Precio_Materiales")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Materiales");

                    b.HasIndex("Id_Proveedor");

                    b.ToTable("Materiales1");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Presupuesto", b =>
                {
                    b.Property<int>("Id_Presupuesto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha_presupuesto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora_Presupuesto")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Equipo")
                        .HasColumnType("int");

                    b.Property<int>("Id_Tecnico")
                        .HasColumnType("int");

                    b.Property<int>("Id_detalle_Presupuesto")
                        .HasColumnType("int");

                    b.Property<int>("Total_Pagar_Presupuesto")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id_Presupuesto");

                    b.HasIndex("Id_Equipo");

                    b.HasIndex("Id_Tecnico");

                    b.HasIndex("Id_detalle_Presupuesto");

                    b.ToTable("Presupuestos");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Proveedor", b =>
                {
                    b.Property<int>("Id_Proveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ciudad_Proveedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Direccion_Proveedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email_Proveedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre_Provedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono_Proveedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Proveedor");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Tecnico", b =>
                {
                    b.Property<int>("Id_Tecnico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos_Tecnico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ciudad_Tecnico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email_Tecnico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre_Tecnico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono_Tecnico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Tecnico");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Detalle_factura", b =>
                {
                    b.HasOne("AppSenaJmoc.Models.Materiales", "Materiales")
                        .WithMany()
                        .HasForeignKey("Id_Materiales")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materiales");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Detalle_presupuesto", b =>
                {
                    b.HasOne("AppSenaJmoc.Models.Materiales", "Materiales")
                        .WithMany()
                        .HasForeignKey("Id_Materiales")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materiales");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Equipo", b =>
                {
                    b.HasOne("AppSenaJmoc.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Factura", b =>
                {
                    b.HasOne("AppSenaJmoc.Models.Detalle_factura", "Detalle_factura")
                        .WithMany()
                        .HasForeignKey("Id_Detalle_factura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppSenaJmoc.Models.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("Id_Equipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppSenaJmoc.Models.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("Id_Tecnico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Detalle_factura");

                    b.Navigation("Equipo");

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Materiales", b =>
                {
                    b.HasOne("AppSenaJmoc.Models.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("Id_Proveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("AppSenaJmoc.Models.Presupuesto", b =>
                {
                    b.HasOne("AppSenaJmoc.Models.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("Id_Equipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppSenaJmoc.Models.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("Id_Tecnico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppSenaJmoc.Models.Detalle_presupuesto", "Detalle_presupuesto")
                        .WithMany()
                        .HasForeignKey("Id_detalle_Presupuesto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Detalle_presupuesto");

                    b.Navigation("Equipo");

                    b.Navigation("Tecnico");
                });
#pragma warning restore 612, 618
        }
    }
}
