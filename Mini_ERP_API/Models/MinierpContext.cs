using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mini_ERP_API.Models;

public partial class MinierpContext : DbContext
{
    public MinierpContext()
    {
    }

    public MinierpContext(DbContextOptions<MinierpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividade> Actividades { get; set; }

    public virtual DbSet<Almacene> Almacenes { get; set; }

    public virtual DbSet<ArchivosEmpresa> ArchivosEmpresas { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<CClaveUnidad> CClaveUnidads { get; set; }

    public virtual DbSet<CMonedum> CMoneda { get; set; }

    public virtual DbSet<CTipoFactor> CTipoFactors { get; set; }

    public virtual DbSet<CUsoCfdi> CUsoCfdis { get; set; }

    public virtual DbSet<Canale> Canales { get; set; }

    public virtual DbSet<Carrito> Carritos { get; set; }

    public virtual DbSet<CatUsuario> CatUsuarios { get; set; }

    public virtual DbSet<CategoriaValoracion> CategoriaValoracions { get; set; }

    public virtual DbSet<CentroBeneficio> CentroBeneficios { get; set; }

    public virtual DbSet<CentroCosto> CentroCostos { get; set; }

    public virtual DbSet<CentroSuministro> CentroSuministros { get; set; }

    public virtual DbSet<CfdiComplementoPago> CfdiComplementoPagos { get; set; }

    public virtual DbSet<CfdiErrore> CfdiErrores { get; set; }

    public virtual DbSet<CfdiRecibida> CfdiRecibidas { get; set; }

    public virtual DbSet<CfdiRecibidasAdjunto> CfdiRecibidasAdjuntos { get; set; }

    public virtual DbSet<ClasesDeDocumentoCompra> ClasesDeDocumentoCompras { get; set; }

    public virtual DbSet<ClasesDeDocumentoVenta> ClasesDeDocumentoVentas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClientesEmpresa> ClientesEmpresas { get; set; }

    public virtual DbSet<ComplementoPago> ComplementoPagos { get; set; }

    public virtual DbSet<CondicionVenta> CondicionVentas { get; set; }

    public virtual DbSet<CondicionesPago> CondicionesPagos { get; set; }

    public virtual DbSet<Configuracion> Configuracions { get; set; }

    public virtual DbSet<ConfiguracionPortal> ConfiguracionPortals { get; set; }

    public virtual DbSet<CtlColonia> CtlColonias { get; set; }

    public virtual DbSet<CtlEstado> CtlEstados { get; set; }

    public virtual DbSet<CtlMunicipio> CtlMunicipios { get; set; }

    public virtual DbSet<CtlTiposDeColonium> CtlTiposDeColonia { get; set; }

    public virtual DbSet<CuentasContable> CuentasContables { get; set; }

    public virtual DbSet<Datum> Data { get; set; }

    public virtual DbSet<DireccionesEntrega> DireccionesEntregas { get; set; }

    public virtual DbSet<DireccionesUsuario> DireccionesUsuarios { get; set; }

    public virtual DbSet<Direccionesrecepcion> Direccionesrecepcions { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<EntradaMaterialCabecera> EntradaMaterialCabeceras { get; set; }

    public virtual DbSet<EntradaMaterialDetalle> EntradaMaterialDetalles { get; set; }

    public virtual DbSet<ErrorFactura> ErrorFacturas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturaCondicione> FacturaCondiciones { get; set; }

    public virtual DbSet<FacturaDetalle> FacturaDetalles { get; set; }

    public virtual DbSet<FacturaGlobal> FacturaGlobals { get; set; }

    public virtual DbSet<FacturasRecibidasPortal> FacturasRecibidasPortals { get; set; }

    public virtual DbSet<FacturasRecibidasPortalDetalle> FacturasRecibidasPortalDetalles { get; set; }

    public virtual DbSet<GrupoCuenta> GrupoCuentas { get; set; }

    public virtual DbSet<GrupoImputacion> GrupoImputacions { get; set; }

    public virtual DbSet<Gruposdecuenta> Gruposdecuentas { get; set; }

    public virtual DbSet<Idioma> Idiomas { get; set; }

    public virtual DbSet<Incoterm> Incoterms { get; set; }

    public virtual DbSet<Interlocutore> Interlocutores { get; set; }

    public virtual DbSet<InventarioAlmacen> InventarioAlmacens { get; set; }

    public virtual DbSet<ListaMaterial> ListaMaterials { get; set; }

    public virtual DbSet<LogConfiguracionUsuario> LogConfiguracionUsuarios { get; set; }

    public virtual DbSet<LogCorreo> LogCorreos { get; set; }

    public virtual DbSet<LogFacturacion> LogFacturacions { get; set; }

    public virtual DbSet<LogP> LogPs { get; set; }

    public virtual DbSet<Materiale> Materiales { get; set; }

    public virtual DbSet<MaterialesFabricadosAlmacene> MaterialesFabricadosAlmacenes { get; set; }

    public virtual DbSet<MetodosSat> MetodosSats { get; set; }

    public virtual DbSet<Movimiento> Movimientos { get; set; }

    public virtual DbSet<MovimientoMaterial> MovimientoMaterials { get; set; }

    public virtual DbSet<ObjetosEnUso> ObjetosEnUsos { get; set; }

    public virtual DbSet<OrdenCompra> OrdenCompras { get; set; }

    public virtual DbSet<OrdenCompraCondicion> OrdenCompraCondicions { get; set; }

    public virtual DbSet<OrdenCompraDetalle> OrdenCompraDetalles { get; set; }

    public virtual DbSet<OrganizacionDeCompra> OrganizacionDeCompras { get; set; }

    public virtual DbSet<OrganizacionDeVenta> OrganizacionDeVentas { get; set; }

    public virtual DbSet<PagoComplementoDetalle> PagoComplementoDetalles { get; set; }

    public virtual DbSet<PagoFactura> PagoFacturas { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<ParametroDeTimbrado> ParametroDeTimbrados { get; set; }

    public virtual DbSet<Pdfcabecera> Pdfcabeceras { get; set; }

    public virtual DbSet<Pdfdetalle> Pdfdetalles { get; set; }

    public virtual DbSet<PedidoCabecera> PedidoCabeceras { get; set; }

    public virtual DbSet<PedidoDetalle> PedidoDetalles { get; set; }

    public virtual DbSet<PedidoVenta> PedidoVentas { get; set; }

    public virtual DbSet<PedidoVentaArticulo> PedidoVentaArticulos { get; set; }

    public virtual DbSet<PedidoVentaCondicione> PedidoVentaCondiciones { get; set; }

    public virtual DbSet<PolizaCabecera> PolizaCabeceras { get; set; }

    public virtual DbSet<PolizaDetalle> PolizaDetalles { get; set; }

    public virtual DbSet<Precio> Precios { get; set; }

    public virtual DbSet<PreciosCliente> PreciosClientes { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<ProveedoresEmpresa> ProveedoresEmpresas { get; set; }

    public virtual DbSet<ProveedoresEmpresa1> ProveedoresEmpresas1 { get; set; }

    public virtual DbSet<RangodeNumero> RangodeNumeros { get; set; }

    public virtual DbSet<RecepcionFacturaDetalle> RecepcionFacturaDetalles { get; set; }

    public virtual DbSet<RecepciondeFacturaCabecera> RecepciondeFacturaCabeceras { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolesUsuario> RolesUsuarios { get; set; }

    public virtual DbSet<SalidaMaterialPedidoVenta> SalidaMaterialPedidoVentas { get; set; }

    public virtual DbSet<SalidaMaterialPedidoVentaDetalle> SalidaMaterialPedidoVentaDetalles { get; set; }

    public virtual DbSet<SecuenciaClaseDocumento> SecuenciaClaseDocumentos { get; set; }

    public virtual DbSet<ServicioEnvioCorreo> ServicioEnvioCorreos { get; set; }

    public virtual DbSet<SolicitudCompra> SolicitudCompras { get; set; }

    public virtual DbSet<SolicitudCompraDetalle> SolicitudCompraDetalles { get; set; }

    public virtual DbSet<TarifarioCliente> TarifarioClientes { get; set; }

    public virtual DbSet<TipoObjeto> TipoObjetos { get; set; }

    public virtual DbSet<TiposCuenta> TiposCuentas { get; set; }

    public virtual DbSet<TmpInventario> TmpInventarios { get; set; }

    public virtual DbSet<TransaccionActividade> TransaccionActividades { get; set; }

    public virtual DbSet<Transaccione> Transacciones { get; set; }

    public virtual DbSet<TransaccionesRole> TransaccionesRoles { get; set; }

    public virtual DbSet<TransporeExterno> TransporeExternos { get; set; }

    public virtual DbSet<TransporteInterno> TransporteInternos { get; set; }

    public virtual DbSet<TransporteInternoDetalle> TransporteInternoDetalles { get; set; }

    public virtual DbSet<UbicacionesEntrega> UbicacionesEntregas { get; set; }

    public virtual DbSet<UnidadesMedidum> UnidadesMedida { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuariosToken> UsuariosTokens { get; set; }

    public virtual DbSet<ViasPago> ViasPagos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividade>(entity =>
        {
            entity.HasKey(e => e.IdActividad).HasName("PRIMARY");

            entity.Property(e => e.IdActividad)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Actividad");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Almacene>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdCentroSuministro)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_CentroSuministro");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ArchivosEmpresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.ToTable("ArchivosEmpresa");

            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Empresa");
            entity.Property(e => e.Certificado).HasMaxLength(500);
            entity.Property(e => e.Llave).HasMaxLength(500);
            entity.Property(e => e.Password).HasMaxLength(100);
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasColumnType("int(11)")
                .HasColumnName("clave");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<CClaveUnidad>(entity =>
        {
            entity.HasKey(e => e.IdClave).HasName("PRIMARY");

            entity.ToTable("c_ClaveUnidad");

            entity.Property(e => e.IdClave)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("id_Clave");
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<CMonedum>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("c_Moneda");

            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("clave");
            entity.Property(e => e.Decimales).HasColumnType("int(11)");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.PorcentajeVariacion).HasColumnType("int(11)");
        });

        modelBuilder.Entity<CTipoFactor>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("c_TipoFactor");

            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("clave");
        });

        modelBuilder.Entity<CUsoCfdi>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("c_UsoCFDI");

            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(100);
        });

        modelBuilder.Entity<Canale>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Carrito>(entity =>
        {
            entity.HasKey(e => e.IdCarrito).HasName("PRIMARY");

            entity.ToTable("Carrito");

            entity.Property(e => e.IdCarrito)
                .HasColumnType("int(11)")
                .HasColumnName("id_Carrito");
            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.Estatus).HasColumnType("bit(1)");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Producto");
            entity.Property(e => e.IdUsusario)
                .HasColumnType("int(11)")
                .HasColumnName("id_Ususario");
        });

        modelBuilder.Entity<CatUsuario>(entity =>
        {
            entity.HasKey(e => e.UsuId).HasName("PRIMARY");

            entity.ToTable("cat_usuarios");

            entity.Property(e => e.UsuId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("usu_id");
            entity.Property(e => e.UsuActivo)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("usu_Activo");
            entity.Property(e => e.UsuClave)
                .HasMaxLength(50)
                .HasColumnName("usu_clave");
            entity.Property(e => e.UsuCorreo)
                .HasMaxLength(100)
                .HasColumnName("usu_correo");
            entity.Property(e => e.UsuEstatus)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("usu_estatus");
            entity.Property(e => e.UsuFechaHora)
                .HasMaxLength(50)
                .HasColumnName("usu_FechaHora");
            entity.Property(e => e.UsuNombre)
                .HasMaxLength(255)
                .HasColumnName("usu_nombre");
            entity.Property(e => e.UsuRfc)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("usu_RFC");
            entity.Property(e => e.UsuTipo)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("usu_tipo");
        });

        modelBuilder.Entity<CategoriaValoracion>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("categoriaValoracion");

            entity.Property(e => e.Clave)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("clave");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(10)
                .HasColumnName("cuentaContable");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<CentroBeneficio>(entity =>
        {
            entity.HasKey(e => e.IdCentroBeneficio).HasName("PRIMARY");

            entity.ToTable("CentroBeneficio");

            entity.Property(e => e.IdCentroBeneficio)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_CentroBeneficio");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.FechaValidez).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdCentroSuministro)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_CentroSuministro");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<CentroCosto>(entity =>
        {
            entity.HasKey(e => e.IdCentroCostos).HasName("PRIMARY");

            entity.ToTable("CentroCosto");

            entity.Property(e => e.IdCentroCostos)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_CentroCostos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.FechaValidez).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdCentroSuministro)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_CentroSuministro");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<CentroSuministro>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("CentroSuministro");

            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .HasColumnName("calle");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdColonia)
                .HasColumnType("int(11)")
                .HasColumnName("id_Colonia");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Empresa");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Numero).HasMaxLength(100);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<CfdiComplementoPago>(entity =>
        {
            entity.HasKey(e => new { e.ComUuidfactura, e.ComUuidcomplemento, e.ComParcialidad, e.ComRfcemisor }).HasName("PRIMARY");

            entity.ToTable("Cfdi_ComplementoPago");

            entity.Property(e => e.ComUuidfactura).HasColumnName("Com_UUIDFactura");
            entity.Property(e => e.ComUuidcomplemento).HasColumnName("Com_UUIDComplemento");
            entity.Property(e => e.ComParcialidad)
                .HasColumnType("int(11)")
                .HasColumnName("Com_Parcialidad");
            entity.Property(e => e.ComRfcemisor)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("Com_RFCEmisor");
            entity.Property(e => e.ComFecha)
                .HasColumnType("date")
                .HasColumnName("Com_Fecha");
            entity.Property(e => e.ComHora)
                .HasColumnType("time")
                .HasColumnName("Com_Hora");
            entity.Property(e => e.ComPago)
                .HasPrecision(19, 4)
                .HasColumnName("Com_Pago");
            entity.Property(e => e.ComSaldo)
                .HasPrecision(19, 4)
                .HasColumnName("Com_Saldo");
            entity.Property(e => e.ComXmlcomplemento)
                .HasColumnType("text")
                .HasColumnName("Com_XMLComplemento");
        });

        modelBuilder.Entity<CfdiErrore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cfdi_errores");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Error)
                .HasMaxLength(255)
                .HasColumnName("error");
            entity.Property(e => e.Hora)
                .HasColumnType("datetime")
                .HasColumnName("hora");
        });

        modelBuilder.Entity<CfdiRecibida>(entity =>
        {
            entity.HasKey(e => new { e.CfdiRecRfc, e.CfdiEmiRfc, e.CfdiRecUuid }).HasName("PRIMARY");

            entity.ToTable("cfdi_recibidas");

            entity.Property(e => e.CfdiRecRfc)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("cfdi_rec_RFC");
            entity.Property(e => e.CfdiEmiRfc)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("cfdi_emi_RFC");
            entity.Property(e => e.CfdiRecUuid).HasColumnName("cfdi_rec_UUID");
            entity.Property(e => e.CfdiRecCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("cfdi_rec_Cancelacion");
            entity.Property(e => e.CfdiRecContrarecibo)
                .HasColumnType("int(11)")
                .HasColumnName("cfdi_rec_contrarecibo");
            entity.Property(e => e.CfdiRecEstatus)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cfdi_rec_Estatus");
            entity.Property(e => e.CfdiRecFechaHoraEmision)
                .HasColumnType("datetime")
                .HasColumnName("cfdi_rec_FechaHora_Emision");
            entity.Property(e => e.CfdiRecFechaHoraRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("cfdi_rec_FechaHora_Recepcion");
            entity.Property(e => e.CfdiRecFolio)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("cfdi_rec_Folio");
            entity.Property(e => e.CfdiRecMotivoRechazo)
                .HasMaxLength(500)
                .HasColumnName("cfdi_rec_MotivoRechazo");
            entity.Property(e => e.CfdiRecSerie)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cfdi_rec_Serie");
            entity.Property(e => e.CfdiRecTipo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("cfdi_rec_Tipo");
            entity.Property(e => e.CfdiRecTotal)
                .HasPrecision(19, 4)
                .HasColumnName("cfdi_rec_Total");
            entity.Property(e => e.CfdiRecXml)
                .HasColumnType("text")
                .HasColumnName("cfdi_rec_XML");
        });

        modelBuilder.Entity<CfdiRecibidasAdjunto>(entity =>
        {
            entity.HasKey(e => new { e.CfdiRecRfc, e.CfdiEmiRfc, e.CfdiRecUuid, e.CfdiRecAdjIndex }).HasName("PRIMARY");

            entity.ToTable("cfdi_recibidas_adjuntos");

            entity.Property(e => e.CfdiRecRfc)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("cfdi_rec_RFC");
            entity.Property(e => e.CfdiEmiRfc)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("cfdi_emi_RFC");
            entity.Property(e => e.CfdiRecUuid).HasColumnName("cfdi_rec_UUID");
            entity.Property(e => e.CfdiRecAdjIndex)
                .HasColumnType("int(11)")
                .HasColumnName("cfdi_rec_adj_index");
            entity.Property(e => e.CfdiRecAdjEstatus)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cfdi_rec_adj_estatus");
            entity.Property(e => e.CfdiRecAdjRuta)
                .HasMaxLength(255)
                .HasColumnName("cfdi_rec_adj_ruta");
            entity.Property(e => e.NombreReal).HasMaxLength(50);
        });

        modelBuilder.Entity<ClasesDeDocumentoCompra>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Empresa)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.Movimiento).HasMaxLength(3);
            entity.Property(e => e.RangoNumeros).HasMaxLength(3);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Tolerancia)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ClasesDeDocumentoVenta>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("clave");
            entity.Property(e => e.ClaseDocumento)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Empresa)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdMovimiento)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("id_Movimiento");
            entity.Property(e => e.RangoNumeros).HasMaxLength(3);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.Adenda)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Calle).HasMaxLength(100);
            entity.Property(e => e.CondicionesDePago)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .HasColumnName("E_mail");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Extension).HasMaxLength(50);
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdBanco)
                .HasColumnType("int(11)")
                .HasColumnName("id_Banco");
            entity.Property(e => e.IdCtlColonias)
                .HasColumnType("int(11)")
                .HasColumnName("id_CTL_COLONIAS");
            entity.Property(e => e.IdViaDePago)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_ViaDePago");
            entity.Property(e => e.Idioma).HasMaxLength(50);
            entity.Property(e => e.LimiteCredito).HasPrecision(19, 4);
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Numero).HasMaxLength(100);
            entity.Property(e => e.Pais)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Rfc1)
                .HasMaxLength(14)
                .HasColumnName("RFC1");
            entity.Property(e => e.Rfc2)
                .HasMaxLength(14)
                .HasColumnName("RFC2");
            entity.Property(e => e.Telefono).HasMaxLength(50);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ClientesEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.IdCliente, e.IdEmpresa }).HasName("PRIMARY");

            entity.ToTable("Clientes_Empresa");

            entity.Property(e => e.IdCliente)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("id_Cliente");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Empresa");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.NoProveedor)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ComplementoPago>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCancelacion).HasColumnType("date");
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaPago).HasColumnType("date");
            entity.Property(e => e.FechaTimbrado).HasColumnType("date");
            entity.Property(e => e.FolioFiscalComplemento).HasMaxLength(36);
            entity.Property(e => e.HoraCancelacion).HasColumnType("time");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraPago).HasColumnType("time");
            entity.Property(e => e.HoraTimbrado).HasColumnType("time");
            entity.Property(e => e.IdComplemeto)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Complemeto");
            entity.Property(e => e.PagoRecibido).HasPrecision(19, 4);
            entity.Property(e => e.Rfcemisor)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("RFCEmisor");
            entity.Property(e => e.Rfcreceptor)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("RFCReceptor");
            entity.Property(e => e.Saldo).HasPrecision(19, 4);
            entity.Property(e => e.UsuarioCancelacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Xmlcomplemento)
                .HasColumnType("text")
                .HasColumnName("XMLComplemento");
        });

        modelBuilder.Entity<CondicionVenta>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.Importe).HasColumnType("int(11)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<CondicionesPago>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("CondicionesPago");

            entity.Property(e => e.Clave)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.ClaveSat)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("ClaveSAT");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.Dias).HasColumnType("int(11)");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Configuracion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Configuracion");

            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Valor).HasMaxLength(100);
        });

        modelBuilder.Entity<ConfiguracionPortal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConfiguracionPortal");

            entity.Property(e => e.ConfiguracionActivo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("Configuracion_Activo");
            entity.Property(e => e.ConfiguracionDescripcion)
                .HasMaxLength(50)
                .HasColumnName("Configuracion_descripcion");
            entity.Property(e => e.ConfiguracionId)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Configuracion_id");
        });

        modelBuilder.Entity<CtlColonia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("CTL_COLONIAS");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.CodigoPostal).HasMaxLength(255);
            entity.Property(e => e.IdMunicipios)
                .HasColumnType("int(11)")
                .HasColumnName("idMunicipios");
            entity.Property(e => e.IdTipoColonia).HasColumnType("int(11)");
            entity.Property(e => e.NombreColonia).HasMaxLength(255);
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<CtlEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("CTL_ESTADOS");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.NombreEstado).HasMaxLength(255);
        });

        modelBuilder.Entity<CtlMunicipio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("CTL_MUNICIPIOS");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdEstados).HasColumnType("int(11)");
            entity.Property(e => e.NombreMunicipio).HasMaxLength(255);
        });

        modelBuilder.Entity<CtlTiposDeColonium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("CTL_TIPOS_DE_COLONIA");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.TipoColonia).HasMaxLength(255);
        });

        modelBuilder.Entity<CuentasContable>(entity =>
        {
            entity.HasKey(e => e.Cuenta).HasName("PRIMARY");

            entity.Property(e => e.Cuenta)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdTipoCuenta)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("id_TipoCuenta");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Datum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("data");

            entity.Property(e => e.Data)
                .HasMaxLength(8000)
                .HasColumnName("data");
        });

        modelBuilder.Entity<DireccionesEntrega>(entity =>
        {
            entity.HasKey(e => e.IdDireccion).HasName("PRIMARY");

            entity.ToTable("direccionesEntrega");

            entity.Property(e => e.IdDireccion)
                .HasColumnType("int(11)")
                .HasColumnName("id_Direccion");
            entity.Property(e => e.Alias).HasMaxLength(100);
            entity.Property(e => e.Calle).HasMaxLength(50);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.Colonia).HasMaxLength(30);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("id_Cliente");
            entity.Property(e => e.IdColonia)
                .HasColumnType("int(11)")
                .HasColumnName("idColonia");
            entity.Property(e => e.NumeroExt).HasMaxLength(50);
            entity.Property(e => e.NumeroInt).HasMaxLength(50);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<DireccionesUsuario>(entity =>
        {
            entity.HasKey(e => e.IdDireccion).HasName("PRIMARY");

            entity.ToTable("direccionesUsuario");

            entity.Property(e => e.IdDireccion)
                .HasColumnType("int(11)")
                .HasColumnName("id_Direccion");
            entity.Property(e => e.Apelldios).HasMaxLength(200);
            entity.Property(e => e.Calle).HasMaxLength(50);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.Colonia).HasMaxLength(50);
            entity.Property(e => e.EntreCalles).HasMaxLength(300);
            entity.Property(e => e.Estado).HasMaxLength(100);
            entity.Property(e => e.IdUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("id_Usuario");
            entity.Property(e => e.NoExt).HasMaxLength(50);
            entity.Property(e => e.NoInt).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Referencias).HasMaxLength(500);
            entity.Property(e => e.TelefonoFijo).HasMaxLength(20);
            entity.Property(e => e.TelefonoMovil).HasMaxLength(20);
        });

        modelBuilder.Entity<Direccionesrecepcion>(entity =>
        {
            entity.HasKey(e => e.IdDireccion).HasName("PRIMARY");

            entity.ToTable("direccionesrecepcion");

            entity.Property(e => e.IdDireccion)
                .HasColumnType("int(11)")
                .HasColumnName("id_Direccion");
            entity.Property(e => e.Alias).HasMaxLength(100);
            entity.Property(e => e.Calle).HasMaxLength(50);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.Colonia).HasMaxLength(50);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdColonia)
                .HasColumnType("int(11)")
                .HasColumnName("idColonia");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Empresa");
            entity.Property(e => e.NumExt).HasMaxLength(50);
            entity.Property(e => e.NumInt).HasMaxLength(50);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Documento");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Nombrereal)
                .HasMaxLength(50)
                .HasColumnName("nombrereal");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Calle).HasMaxLength(150);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdCtlColonias)
                .HasColumnType("int(11)")
                .HasColumnName("id_CTL_COLONIAS");
            entity.Property(e => e.IdCuentasContables)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_CuentasContables");
            entity.Property(e => e.Numero).HasMaxLength(150);
            entity.Property(e => e.Pais)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.RazonSocial).HasMaxLength(50);
            entity.Property(e => e.RegimenFiscal)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Rfc)
                .HasMaxLength(15)
                .HasColumnName("RFC");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<EntradaMaterialCabecera>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EntradaMaterialCabecera");

            entity.Property(e => e.Estatus)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FechaHora).HasMaxLength(50);
            entity.Property(e => e.IdEntradaMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_EntradaMaterial");
            entity.Property(e => e.IdOrden)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Orden");
            entity.Property(e => e.IdTipoDocumento)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_TipoDocumento");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<EntradaMaterialDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EntradaMaterialDetalle");

            entity.Property(e => e.Almacen)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Caducidad).HasMaxLength(50);
            entity.Property(e => e.CantidadFacturada).HasColumnType("int(11)");
            entity.Property(e => e.CantidadRecibida).HasColumnType("int(11)");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.IdEntradaMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_EntradaMaterial");
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.IdOrden)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Orden");
            entity.Property(e => e.Lote)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("lote");
            entity.Property(e => e.Posicion).HasColumnType("int(11)");
            entity.Property(e => e.Umrecibida)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("UMRecibida");
        });

        modelBuilder.Entity<ErrorFactura>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Archivo).HasColumnType("text");
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Hora).HasColumnType("time");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Factura");
            entity.Property(e => e.MensageError).HasMaxLength(1000);
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PRIMARY");

            entity.ToTable("Factura");

            entity.Property(e => e.IdFactura)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Factura");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCancelacion).HasColumnType("date");
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaTimbrado).HasColumnType("date");
            entity.Property(e => e.HoraCancelacion).HasColumnType("time");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraTimbrado).HasColumnType("time");
            entity.Property(e => e.IdClaseDocumento)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("id_ClaseDocumento");
            entity.Property(e => e.Iva).HasPrecision(19, 4);
            entity.Property(e => e.NoCertificadoSat)
                .HasMaxLength(500)
                .HasColumnName("NoCertificadoSAT");
            entity.Property(e => e.PrecioFacturado)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Sello).HasMaxLength(500);
            entity.Property(e => e.SelloSat).HasMaxLength(500);
            entity.Property(e => e.Subtotal).HasPrecision(19, 4);
            entity.Property(e => e.Timbrado).HasMaxLength(500);
            entity.Property(e => e.UsuarioCancelacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Xml)
                .HasColumnType("text")
                .HasColumnName("XML");
        });

        modelBuilder.Entity<FacturaCondicione>(entity =>
        {
            entity.HasKey(e => new { e.IdFactura, e.IdPosicion, e.IdCondicion, e.IdSalidaMaterial }).HasName("PRIMARY");

            entity.Property(e => e.IdFactura)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Factura");
            entity.Property(e => e.IdPosicion)
                .HasColumnType("int(11)")
                .HasColumnName("id_Posicion");
            entity.Property(e => e.IdCondicion)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Condicion");
            entity.Property(e => e.IdSalidaMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_SalidaMaterial");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Valor)
                .HasPrecision(19, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<FacturaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdFactura, e.IdPosicion, e.IdSalidaMaterial }).HasName("PRIMARY");

            entity.ToTable("FacturaDetalle");

            entity.Property(e => e.IdFactura)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Factura");
            entity.Property(e => e.IdPosicion)
                .HasColumnType("int(11)")
                .HasColumnName("id_Posicion");
            entity.Property(e => e.IdSalidaMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_SalidaMaterial");
            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.Valor).HasPrecision(19, 4);
        });

        modelBuilder.Entity<FacturaGlobal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FacturaGlobal");

            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Fecha1).HasColumnType("date");
            entity.Property(e => e.Fecha2).HasColumnType("date");
            entity.Property(e => e.Hora)
                .HasColumnType("time")
                .HasColumnName("hora");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Factura");
            entity.Property(e => e.Usuario)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<FacturasRecibidasPortal>(entity =>
        {
            entity.HasKey(e => new { e.IdOrden, e.FolioFiscal }).HasName("PRIMARY");

            entity.ToTable("FacturasRecibidasPortal");

            entity.Property(e => e.IdOrden)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Orden");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Empresa).HasMaxLength(15);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaRoa)
                .HasColumnType("date")
                .HasColumnName("FechaROA");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Hora).HasColumnType("time");
            entity.Property(e => e.HoraRoa)
                .HasColumnType("time")
                .HasColumnName("HoraROA");
            entity.Property(e => e.MotivoRechazo).HasMaxLength(500);
            entity.Property(e => e.Proveedor).HasMaxLength(15);
            entity.Property(e => e.Serie)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TipoFactura)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Total).HasPrecision(19, 4);
            entity.Property(e => e.UsuarioRoa)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("UsuarioROA");
            entity.Property(e => e.Xml)
                .HasColumnType("text")
                .HasColumnName("XML");
        });

        modelBuilder.Entity<FacturasRecibidasPortalDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdOrden, e.Uuid, e.Partida }).HasName("PRIMARY");

            entity.ToTable("FacturasRecibidasPortalDetalle");

            entity.Property(e => e.IdOrden)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Orden");
            entity.Property(e => e.Uuid).HasColumnName("UUID");
            entity.Property(e => e.Partida).HasColumnType("int(11)");
            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.Estatus).HasMaxLength(20);
            entity.Property(e => e.Iva)
                .HasPrecision(19, 4)
                .HasColumnName("IVA");
            entity.Property(e => e.Monto).HasPrecision(19, 4);
        });

        modelBuilder.Entity<GrupoCuenta>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("grupoCuentas");

            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<GrupoImputacion>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("GrupoImputacion");

            entity.Property(e => e.Clave)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("clave");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(10)
                .HasColumnName("cuentaContable");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Gruposdecuenta>(entity =>
        {
            entity.HasKey(e => e.IdGrupo).HasName("PRIMARY");

            entity.Property(e => e.IdGrupo)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("id_Grupo");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdRango)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("id_Rango");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Idioma>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.IdIdioma)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Id_Idioma");
        });

        modelBuilder.Entity<Incoterm>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Interlocutore>(entity =>
        {
            entity.HasKey(e => new { e.Clave, e.IdCliente }).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.IdCliente)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("id_Cliente");
            entity.Property(e => e.IdCliente2)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("id_Cliente2");
        });

        modelBuilder.Entity<InventarioAlmacen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InventarioAlmacen");

            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Almacen");
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.Ubicacion).HasMaxLength(100);
        });

        modelBuilder.Entity<ListaMaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ListaMaterial");

            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.Costo).HasPrecision(19, 4);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.ListaId)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Lista_id");
            entity.Property(e => e.Um)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("UM");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<LogConfiguracionUsuario>(entity =>
        {
            entity.HasKey(e => e.Consecutivo).HasName("PRIMARY");

            entity.ToTable("Log_Configuracion_Usuarios");

            entity.Property(e => e.Consecutivo).HasColumnType("int(11)");
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Hora).HasColumnType("time");
            entity.Property(e => e.IdMensaje)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Mensaje");
            entity.Property(e => e.Instancia)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Mensaje).HasMaxLength(50);
            entity.Property(e => e.Proceso)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Usuario)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<LogCorreo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Log_Correos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(200)
                .HasColumnName("destinatario");
            entity.Property(e => e.Documento)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("documento");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fechaHora");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(500)
                .HasColumnName("mensaje");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("tipoDocumento");
        });

        modelBuilder.Entity<LogFacturacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("LOG_Facturacion");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Factura");
            entity.Property(e => e.IdRemision)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Remision");
            entity.Property(e => e.RazonSocial).HasMaxLength(250);
            entity.Property(e => e.Rfc)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("RFC");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.UsuCfdi)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("UsuCFDI");
        });

        modelBuilder.Entity<LogP>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOG_P");

            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Hora).HasColumnType("time");
            entity.Property(e => e.IdMensaje)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Id_Mensaje");
            entity.Property(e => e.Ins).HasMaxLength(50);
            entity.Property(e => e.Mensaje).HasMaxLength(1500);
            entity.Property(e => e.Prioridad)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Proceso)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Tipo).HasMaxLength(20);
            entity.Property(e => e.Usuario)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Materiale>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CantidadEmpaqueCompra).HasColumnType("int(11)");
            entity.Property(e => e.CantidadEmpaqueVenta).HasColumnType("int(11)");
            entity.Property(e => e.CodigoEan)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("CodigoEAN");
            entity.Property(e => e.CodigoSat)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.ListaMaterial)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ManoObra).HasPrecision(19, 4);
            entity.Property(e => e.NombreCorto).HasMaxLength(50);
            entity.Property(e => e.NombreLargo).HasMaxLength(150);
            entity.Property(e => e.Pintura).HasPrecision(19, 4);
            entity.Property(e => e.StockMinimo).HasColumnType("int(11)");
            entity.Property(e => e.TipoMaterial)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.TotalCaracteresgrabado).HasColumnType("int(11)");
            entity.Property(e => e.UnidadEmpaqueCompra).HasMaxLength(30);
            entity.Property(e => e.UnidadEmpaqueVenta).HasMaxLength(30);
            entity.Property(e => e.UnidadMedidaCompra)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.UnidadMedidaVenta)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<MaterialesFabricadosAlmacene>(entity =>
        {
            entity.HasKey(e => new { e.IdMaterial, e.IdAlmacenFabricacion, e.IdAlmacen }).HasName("PRIMARY");

            entity.ToTable("MaterialesFabricados_Almacenes");

            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Material");
            entity.Property(e => e.IdAlmacenFabricacion)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("Id_AlmacenFabricacion");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("Id_Almacen");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuariCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<MetodosSat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MetodosSAT");

            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Movimiento>(entity =>
        {
            entity.HasKey(e => e.IdMovimiento).HasName("PRIMARY");

            entity.Property(e => e.IdMovimiento)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("id_Movimiento");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.Requerimientos).HasMaxLength(50);
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<MovimientoMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("MovimientoMaterial");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AlmacenDestino)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.AlmacenOrigen)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Caducidad).HasColumnType("date");
            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.DocumentoFuente)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Hora).HasColumnType("time");
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.MotivoCancelacion).HasMaxLength(200);
            entity.Property(e => e.Movimiento)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<ObjetosEnUso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ObjetosEnUso");

            entity.Property(e => e.IdTipoObjeto)
                .HasColumnType("int(11)")
                .HasColumnName("Id_TipoObjeto");
            entity.Property(e => e.IdUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("Id_Usuario");
            entity.Property(e => e.Objeto).HasMaxLength(12);
        });

        modelBuilder.Entity<OrdenCompra>(entity =>
        {
            entity.HasKey(e => e.IdOrden).HasName("PRIMARY");

            entity.ToTable("OrdenCompra");

            entity.Property(e => e.IdOrden)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Orden");
            entity.Property(e => e.CentroCosto)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.CondicionPago)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Empresa).HasMaxLength(50);
            entity.Property(e => e.Estatus)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FechaEntrega).HasMaxLength(50);
            entity.Property(e => e.FechaHora).HasMaxLength(50);
            entity.Property(e => e.IdOrganizacion)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Organizacion");
            entity.Property(e => e.IdPedido)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Pedido");
            entity.Property(e => e.IdTipoDocumento)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("id_TipoDocumento");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Usuario");
            entity.Property(e => e.LugarEntrega).HasColumnType("int(11)");
            entity.Property(e => e.MotivoCancelacion).HasMaxLength(50);
            entity.Property(e => e.Provedor).HasMaxLength(50);
            entity.Property(e => e.Solicitante)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TotalOrden).HasPrecision(19, 4);
        });

        modelBuilder.Entity<OrdenCompraCondicion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrdenCompraCondicion");

            entity.Property(e => e.IdCondicion)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Condicion");
            entity.Property(e => e.IdOrden)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Orden");
            entity.Property(e => e.Partida).HasColumnType("int(11)");
            entity.Property(e => e.Valor).HasPrecision(19, 4);
        });

        modelBuilder.Entity<OrdenCompraDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdOrden, e.Posicion }).HasName("PRIMARY");

            entity.ToTable("OrdenCompraDetalle");

            entity.Property(e => e.IdOrden)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Orden");
            entity.Property(e => e.Posicion).HasColumnType("int(11)");
            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Estatus).HasMaxLength(50);
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.Material).HasMaxLength(50);
            entity.Property(e => e.Monto).HasPrecision(19, 4);
            entity.Property(e => e.Precio).HasPrecision(19, 4);
            entity.Property(e => e.Um)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("UM");
        });

        modelBuilder.Entity<OrganizacionDeCompra>(entity =>
        {
            entity.HasKey(e => e.OrganizacionComprasId).HasName("PRIMARY");

            entity.Property(e => e.OrganizacionComprasId)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("OrganizacionCompras_id");
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdCentroLogistico)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_CentroLogistico");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<OrganizacionDeVenta>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdCentroLogistico)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_CentroLogistico");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PagoComplementoDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PagoComplementoDetalle");

            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FolioFiscal).HasMaxLength(36);
            entity.Property(e => e.IdComplemento)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Complemento");
            entity.Property(e => e.Pago).HasPrecision(19, 4);
            entity.Property(e => e.Parcialidad).HasColumnType("int(11)");
            entity.Property(e => e.SaldoAnterior).HasPrecision(19, 4);
            entity.Property(e => e.SaldoInsoluto).HasPrecision(19, 4);
        });

        modelBuilder.Entity<PagoFactura>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Hora).HasColumnType("time");
            entity.Property(e => e.IdOrden)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Orden");
            entity.Property(e => e.IdPago)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Pago");
            entity.Property(e => e.IdRecepcion)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Recepcion");
            entity.Property(e => e.Pago).HasPrecision(19, 4);
            entity.Property(e => e.Parcialidad).HasColumnType("int(11)");
            entity.Property(e => e.Saldo).HasPrecision(19, 4);
            entity.Property(e => e.Usuario)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Uuidcomplemento).HasColumnName("UUIDComplemento");
            entity.Property(e => e.Uuidfactura).HasColumnName("UUIDFactura");
            entity.Property(e => e.Xmlcomplemento)
                .HasColumnType("text")
                .HasColumnName("XMLComplemento");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.PaisDescripcion)
                .HasMaxLength(50)
                .HasColumnName("Pais_Descripcion");
            entity.Property(e => e.PaisId)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Pais_Id");
        });

        modelBuilder.Entity<ParametroDeTimbrado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParametroDeTimbrado");

            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Id_empresa");
            entity.Property(e => e.ModoTimbrado).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Pdfcabecera>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PDFCabecera");

            entity.Property(e => e.CadenaOriginal).HasMaxLength(50);
            entity.Property(e => e.CerEmisor).HasMaxLength(50);
            entity.Property(e => e.CerSat)
                .HasMaxLength(50)
                .HasColumnName("CerSAT");
            entity.Property(e => e.Cfdirelacion)
                .HasMaxLength(50)
                .HasColumnName("CFDIRelacion");
            entity.Property(e => e.Cfdirelacionado)
                .HasMaxLength(50)
                .HasColumnName("CFDIRelacionado");
            entity.Property(e => e.Cliente).HasMaxLength(50);
            entity.Property(e => e.Descuentos).HasMaxLength(50);
            entity.Property(e => e.Domicilio).HasMaxLength(50);
            entity.Property(e => e.Fecha).HasMaxLength(50);
            entity.Property(e => e.FechaHora).HasMaxLength(50);
            entity.Property(e => e.Folio)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FormaPago).HasMaxLength(50);
            entity.Property(e => e.ImpRetenidos).HasMaxLength(50);
            entity.Property(e => e.ImpTrasladados).HasMaxLength(50);
            entity.Property(e => e.Lugar)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NoPedido).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasMaxLength(50);
            entity.Property(e => e.RegimenFiscal).HasMaxLength(50);
            entity.Property(e => e.Rfcemisor)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("RFCEmisor");
            entity.Property(e => e.Rfcreceptor)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("RFCReceptor");
            entity.Property(e => e.SelloDigital).HasMaxLength(50);
            entity.Property(e => e.SelloSat)
                .HasMaxLength(50)
                .HasColumnName("SelloSAT");
            entity.Property(e => e.Subtotal).HasMaxLength(50);
            entity.Property(e => e.TipoComprobante).HasMaxLength(50);
            entity.Property(e => e.TipoRelacion).HasMaxLength(50);
            entity.Property(e => e.Total).HasMaxLength(50);
            entity.Property(e => e.TotalLetra).HasMaxLength(50);
            entity.Property(e => e.UsoCfdi)
                .HasMaxLength(50)
                .HasColumnName("UsoCFDI");
            entity.Property(e => e.Uuid)
                .HasMaxLength(50)
                .HasColumnName("UUID");
        });

        modelBuilder.Entity<Pdfdetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PDFDetalle");

            entity.Property(e => e.Cantidad)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ClaveServicio)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ClaveUnidadSat)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ClaveUnidadSAT");
            entity.Property(e => e.Concepto).HasMaxLength(150);
            entity.Property(e => e.Folio)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.Impuestos).HasMaxLength(50);
            entity.Property(e => e.Partida)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Unidad)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ValorUnitario).HasMaxLength(50);
        });

        modelBuilder.Entity<PedidoCabecera>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PRIMARY");

            entity.ToTable("PedidoCabecera");

            entity.Property(e => e.IdPedido)
                .HasColumnType("int(11)")
                .HasColumnName("id_Pedido");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdDireccion)
                .HasColumnType("int(11)")
                .HasColumnName("id_Direccion");
            entity.Property(e => e.IdUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("id_Usuario");
        });

        modelBuilder.Entity<PedidoDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PedidoDetalle");

            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.IdPedido)
                .HasColumnType("int(11)")
                .HasColumnName("id_Pedido");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Producto");
            entity.Property(e => e.Precio).HasPrecision(19, 4);
        });

        modelBuilder.Entity<PedidoVenta>(entity =>
        {
            entity.HasKey(e => e.IdPedidoVentas).HasName("PRIMARY");

            entity.Property(e => e.IdPedidoVentas)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_PedidoVentas");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.FechaEntrega).HasColumnType("date");
            entity.Property(e => e.FechaHoraPedido).HasColumnType("datetime");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.HoraEntrega).HasColumnType("time");
            entity.Property(e => e.IdCanales)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Canales");
            entity.Property(e => e.IdClasesPedido)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("id_ClasesPedido");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("id_Cliente");
            entity.Property(e => e.IdCondicionesPago)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_CondicionesPago");
            entity.Property(e => e.IdDireccionEntrega)
                .HasColumnType("int(11)")
                .HasColumnName("id_DireccionEntrega");
            entity.Property(e => e.IdIncoterms)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Incoterms");
            entity.Property(e => e.IdInterlocutor)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Interlocutor");
            entity.Property(e => e.IdOrganizacionVentas)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_OrganizacionVentas");
            entity.Property(e => e.IdViasDePago)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_ViasDePago");
            entity.Property(e => e.Metodo)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.PedidoCliente).HasMaxLength(20);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PedidoVentaArticulo>(entity =>
        {
            entity.HasKey(e => new { e.IdPedidoVentas, e.Posicion }).HasName("PRIMARY");

            entity.Property(e => e.IdPedidoVentas)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_PedidoVentas");
            entity.Property(e => e.Posicion).HasColumnType("int(11)");
            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.IdCentroBeneficio)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_CentroBeneficio");
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.Monto).HasPrecision(19, 4);
            entity.Property(e => e.Precio).HasPrecision(19, 4);
        });

        modelBuilder.Entity<PedidoVentaCondicione>(entity =>
        {
            entity.HasKey(e => new { e.IdPedidoVentas, e.IdPosicion, e.IdCondicion }).HasName("PRIMARY");

            entity.Property(e => e.IdPedidoVentas)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_PedidoVentas");
            entity.Property(e => e.IdPosicion)
                .HasColumnType("int(11)")
                .HasColumnName("id_Posicion");
            entity.Property(e => e.IdCondicion)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Condicion");
            entity.Property(e => e.Valor).HasPrecision(19, 4);
        });

        modelBuilder.Entity<PolizaCabecera>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PolizaCabecera");

            entity.Property(e => e.Año).HasColumnType("date");
            entity.Property(e => e.DocComp)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Empresa)
                .HasMaxLength(25)
                .IsFixedLength();
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FechaContabilizacion).HasColumnType("date");
            entity.Property(e => e.FechaRegistro).HasColumnType("date");
            entity.Property(e => e.HoraRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdEmpresa)
                .HasColumnType("int(11)")
                .HasColumnName("id_Empresa");
            entity.Property(e => e.IdPoliza)
                .HasColumnType("int(11)")
                .HasColumnName("id_Poliza");
            entity.Property(e => e.IdRecepcion)
                .HasColumnType("int(11)")
                .HasColumnName("id_Recepcion");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NoDoc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("No_Doc");
            entity.Property(e => e.Periodo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Usuario)
                .HasMaxLength(15)
                .IsFixedLength();
        });

        modelBuilder.Entity<PolizaDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PolizaDetalle");

            entity.Property(e => e.CuentaContable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasColumnType("int(11)")
                .HasColumnName("id_Empresa");
            entity.Property(e => e.IdPoliza)
                .HasColumnType("int(11)")
                .HasColumnName("id_Poliza");
            entity.Property(e => e.IdRecepcion)
                .HasColumnType("int(11)")
                .HasColumnName("id_Recepcion");
            entity.Property(e => e.NoDoc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("No_Doc");
        });

        modelBuilder.Entity<Precio>(entity =>
        {
            entity.HasKey(e => new { e.Clave, e.IdMaterial, e.Vigencia }).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.Vigencia).HasColumnType("date");
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.PrecioInternet).HasPrecision(19, 4);
            entity.Property(e => e.PrecioLista).HasPrecision(19, 4);
            entity.Property(e => e.PrecioMostrador).HasPrecision(19, 4);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PreciosCliente>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("PreciosCliente");

            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("id_Cliente");
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.PrecioInternet).HasPrecision(19, 4);
            entity.Property(e => e.PrecioLista).HasPrecision(19, 4);
            entity.Property(e => e.PrecioMostrador).HasPrecision(19, 4);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Vigencia).HasColumnType("date");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Calle).HasMaxLength(100);
            entity.Property(e => e.CondicionPago).HasMaxLength(100);
            entity.Property(e => e.CuentaBancaria).HasMaxLength(100);
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .HasColumnName("E_mail");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Extension).HasMaxLength(50);
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdBanco)
                .HasColumnType("int(11)")
                .HasColumnName("id_Banco");
            entity.Property(e => e.IdColonia)
                .HasColumnType("int(11)")
                .HasColumnName("id_Colonia");
            entity.Property(e => e.IdViaDePago)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_ViaDePago");
            entity.Property(e => e.Idioma)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Numero).HasMaxLength(50);
            entity.Property(e => e.Pais)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Rfc1)
                .HasMaxLength(15)
                .HasColumnName("RFC1");
            entity.Property(e => e.Rfc2)
                .HasMaxLength(15)
                .HasColumnName("RFC2");
            entity.Property(e => e.Telefono).HasMaxLength(50);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProveedoresEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.IdProveedor, e.IdEmpresa }).HasName("PRIMARY");

            entity.ToTable("ProveedoresEmpresa");

            entity.Property(e => e.IdProveedor)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Proveedor");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Empresa");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.NoCliente).HasMaxLength(50);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProveedoresEmpresa1>(entity =>
        {
            entity.HasKey(e => new { e.IdProveedor, e.IdEmpresa }).HasName("PRIMARY");

            entity.ToTable("Proveedores_Empresa");

            entity.Property(e => e.IdProveedor)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Proveedor");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("id_Empresa");
        });

        modelBuilder.Entity<RangodeNumero>(entity =>
        {
            entity.HasKey(e => e.IdRango).HasName("PRIMARY");

            entity.Property(e => e.IdRango)
                .HasMaxLength(3)
                .HasColumnName("id_Rango");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.FinRango)
                .HasMaxLength(10)
                .HasColumnName("finRango");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.InicioRango).HasMaxLength(10);
            entity.Property(e => e.NumeroActual)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<RecepcionFacturaDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RecepcionFacturaDetalle");

            entity.Property(e => e.Articulo).HasMaxLength(50);
            entity.Property(e => e.IdFactura)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Factura");
            entity.Property(e => e.Importe)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Posicion).HasColumnType("int(11)");
            entity.Property(e => e.Valorunitario)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<RecepciondeFacturaCabecera>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PRIMARY");

            entity.ToTable("RecepciondeFacturaCabecera");

            entity.Property(e => e.IdFactura)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_factura");
            entity.Property(e => e.FechadeRecepcion).HasMaxLength(50);
            entity.Property(e => e.IdOrden)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_orden");
            entity.Property(e => e.RfcEmisor)
                .HasMaxLength(50)
                .HasColumnName("rfcEmisor");
            entity.Property(e => e.Uuid)
                .HasMaxLength(50)
                .HasColumnName("UUID");
            entity.Property(e => e.Xml)
                .HasColumnType("text")
                .HasColumnName("XML");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PRIMARY");

            entity.Property(e => e.IdRol)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Id_Rol");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<RolesUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RolesUsuario");

            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdRol)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Id_Rol");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Id_Usuario");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<SalidaMaterialPedidoVenta>(entity =>
        {
            entity.HasKey(e => e.IdSalidaMaterial).HasName("PRIMARY");

            entity.Property(e => e.IdSalidaMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_SalidaMaterial");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FechaDocumento).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.FechaPicking).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Almacen");
            entity.Property(e => e.IdPedidoVentas)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_PedidoVentas");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<SalidaMaterialPedidoVentaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdSalidaMaterial, e.Posicion }).HasName("PRIMARY");

            entity.ToTable("SalidaMaterialPedidoVentaDetalle");

            entity.Property(e => e.IdSalidaMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_SalidaMaterial");
            entity.Property(e => e.Posicion).HasColumnType("int(11)");
            entity.Property(e => e.CantidaPicking).HasColumnType("int(11)");
            entity.Property(e => e.IdPedidoVentas)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_PedidoVentas");
            entity.Property(e => e.Umpicking)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("UMPicking");
        });

        modelBuilder.Entity<SecuenciaClaseDocumento>(entity =>
        {
            entity.HasKey(e => new { e.TipoDocumentos, e.ClaseD1, e.ClaseD2, e.ClaseD3 }).HasName("PRIMARY");

            entity.Property(e => e.TipoDocumentos)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ClaseD1)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ClaseD2)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ClaseD3)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ClaseD4)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ServicioEnvioCorreo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ServicioEnvioCorreo");

            entity.Property(e => e.Contraseña).HasMaxLength(50);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Puerto).HasMaxLength(50);
            entity.Property(e => e.ServidorSmt)
                .HasMaxLength(50)
                .HasColumnName("ServidorSMT");
            entity.Property(e => e.Transaccion)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<SolicitudCompra>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud).HasName("PRIMARY");

            entity.ToTable("SolicitudCompra");

            entity.Property(e => e.IdSolicitud)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Solicitud");
            entity.Property(e => e.Empresa)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FechaEntrega).HasMaxLength(50);
            entity.Property(e => e.FechaHoraOrden).HasMaxLength(50);
            entity.Property(e => e.IdOrganizacion)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Organizacion");
            entity.Property(e => e.IdSolicitante)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Solicitante");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<SolicitudCompraDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdSolicitud, e.Posicion }).HasName("PRIMARY");

            entity.ToTable("SolicitudCompraDetalle");

            entity.Property(e => e.IdSolicitud)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Solicitud");
            entity.Property(e => e.Posicion).HasColumnType("int(11)");
            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Material");
            entity.Property(e => e.Material).HasMaxLength(50);
            entity.Property(e => e.Um)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("UM");
        });

        modelBuilder.Entity<TarifarioCliente>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.IdCliente)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("id_Cliente");
            entity.Property(e => e.IdTarifario)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("id_Tarifario");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoObjeto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TipoObjeto");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.IdTipoObjetos)
                .HasColumnType("int(11)")
                .HasColumnName("Id_TipoObjetos");
        });

        modelBuilder.Entity<TiposCuenta>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.Property(e => e.Clave)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<TmpInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_inventario");

            entity.Property(e => e.Descripcion).HasMaxLength(150);
            entity.Property(e => e.Existencia).HasColumnType("int(11)");
            entity.Property(e => e.IdMateiral)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Mateiral");
            entity.Property(e => e.Linea).HasColumnType("int(11)");
            entity.Property(e => e.Proveedor).HasMaxLength(50);
        });

        modelBuilder.Entity<TransaccionActividade>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdActividad)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Actividad");
            entity.Property(e => e.IdTransaccion)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("Id_Transaccion");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Transaccione>(entity =>
        {
            entity.HasKey(e => e.IdTransaccion).HasName("PRIMARY");

            entity.Property(e => e.IdTransaccion)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("Id_Transaccion");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<TransaccionesRole>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.IdActividad)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Actividad");
            entity.Property(e => e.IdRol)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Id_Rol");
            entity.Property(e => e.IdTransaccion)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("Id_Transaccion");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<TransporeExterno>(entity =>
        {
            entity.HasKey(e => e.IdSalidaMaterial).HasName("PRIMARY");

            entity.ToTable("TransporeExterno");

            entity.Property(e => e.IdSalidaMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_SalidaMaterial");
            entity.Property(e => e.ClaveTrranportista)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Costo).HasPrecision(19, 4);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.NoGuia)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<TransporteInterno>(entity =>
        {
            entity.HasKey(e => e.IdTransporte).HasName("PRIMARY");

            entity.ToTable("TransporteInterno");

            entity.Property(e => e.IdTransporte)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Transporte");
            entity.Property(e => e.CostoCaseta).HasPrecision(19, 4);
            entity.Property(e => e.CostoGasolina).HasPrecision(19, 4);
            entity.Property(e => e.CostoTag).HasPrecision(19, 4);
            entity.Property(e => e.EfectivoExtra).HasPrecision(19, 4);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.NombreChofer).HasMaxLength(30);
            entity.Property(e => e.Placas).HasMaxLength(15);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<TransporteInternoDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransporteInternoDetalle");

            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.IdSalidaMaterial)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_SalidaMaterial");
            entity.Property(e => e.IdTransporte)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_Transporte");
            entity.Property(e => e.Posicion).HasColumnType("int(11)");
        });

        modelBuilder.Entity<UbicacionesEntrega>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("UbicacionesEntrega");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.IdUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("id_Usuario");
        });

        modelBuilder.Entity<UnidadesMedidum>(entity =>
        {
            entity.HasKey(e => e.IdClave).HasName("PRIMARY");

            entity.Property(e => e.IdClave)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("id_Clave");
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.IdClaveSat)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("id_ClaveSat");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PRIMARY");

            entity.Property(e => e.IdUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("id_Usuario");
            entity.Property(e => e.Activo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.ApellidoMaternoUsuario)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ApellidoMaterno_Usuario");
            entity.Property(e => e.ApellidoPaternoUsuario)
                .HasMaxLength(100)
                .HasColumnName("ApellidoPaterno_Usuario");
            entity.Property(e => e.EmailUsuario)
                .HasMaxLength(100)
                .HasColumnName("Email_Usuario");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaAcceso).HasColumnType("date");
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraAcceso).HasColumnType("time");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(100)
                .HasColumnName("Nombre_Usuario");
            entity.Property(e => e.PasswordUsuario)
                .HasMaxLength(500)
                .HasColumnName("Password_Usuario");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Usuario1)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Usuario");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<UsuariosToken>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.Token }).HasName("PRIMARY");

            entity.ToTable("UsuariosToken");

            entity.Property(e => e.IdUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("id_Usuario");
            entity.Property(e => e.Token).HasMaxLength(500);
        });

        modelBuilder.Entity<ViasPago>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PRIMARY");

            entity.ToTable("ViasPago");

            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEliminacion).HasColumnType("date");
            entity.Property(e => e.HoraCreacion).HasColumnType("time");
            entity.Property(e => e.HoraEliminacion).HasColumnType("time");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.UsuarioEliminacion)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
