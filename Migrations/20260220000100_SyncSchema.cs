namespace PosDesktop.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SyncSchema : DbMigration
    {
        public override void Up()
        {
            Sql(@"
IF OBJECT_ID(N'dbo.Lineas', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Lineas](
        [id] INT IDENTITY(1,1) NOT NULL,
        [nombre] NVARCHAR(MAX) NOT NULL,
        [descripcion] NVARCHAR(MAX) NULL,
        CONSTRAINT [PK_dbo.Lineas] PRIMARY KEY CLUSTERED ([id] ASC)
    );
END

IF OBJECT_ID(N'dbo.Proveedors', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Proveedors](
        [id] INT IDENTITY(1,1) NOT NULL,
        [razonSocial] NVARCHAR(MAX) NOT NULL,
        [direccion] NVARCHAR(MAX) NOT NULL,
        [telefono] NVARCHAR(MAX) NOT NULL,
        [correo] NVARCHAR(MAX) NOT NULL,
        [contacto] NVARCHAR(MAX) NULL,
        [observaciones] NVARCHAR(MAX) NULL,
        CONSTRAINT [PK_dbo.Proveedors] PRIMARY KEY CLUSTERED ([id] ASC)
    );
END

IF OBJECT_ID(N'dbo.Articuloes', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Articuloes](
        [id] INT IDENTITY(1,1) NOT NULL,
        [codigo] NVARCHAR(MAX) NOT NULL,
        [nombre] NVARCHAR(MAX) NOT NULL,
        [descripcion] NVARCHAR(MAX) NOT NULL,
        [precio] DECIMAL(18,2) NOT NULL,
        [porcentaje] DECIMAL(18,2) NOT NULL,
        [costo] DECIMAL(18,2) NOT NULL,
        [stock] INT NOT NULL,
        [linea_id] INT NULL,
        [proveedor_id] INT NULL,
        CONSTRAINT [PK_dbo.Articuloes] PRIMARY KEY CLUSTERED ([id] ASC)
    );
END
ELSE
BEGIN
    IF COL_LENGTH(N'dbo.Articuloes', N'codigo') IS NULL
        ALTER TABLE [dbo].[Articuloes] ADD [codigo] NVARCHAR(MAX) NOT NULL DEFAULT N'';
    IF COL_LENGTH(N'dbo.Articuloes', N'nombre') IS NULL
        ALTER TABLE [dbo].[Articuloes] ADD [nombre] NVARCHAR(MAX) NOT NULL DEFAULT N'';
    IF COL_LENGTH(N'dbo.Articuloes', N'descripcion') IS NULL
        ALTER TABLE [dbo].[Articuloes] ADD [descripcion] NVARCHAR(MAX) NOT NULL DEFAULT N'';
    IF COL_LENGTH(N'dbo.Articuloes', N'precio') IS NULL
        ALTER TABLE [dbo].[Articuloes] ADD [precio] DECIMAL(18,2) NOT NULL DEFAULT 0;
    IF COL_LENGTH(N'dbo.Articuloes', N'porcentaje') IS NULL
        ALTER TABLE [dbo].[Articuloes] ADD [porcentaje] DECIMAL(18,2) NOT NULL DEFAULT 0;
    IF COL_LENGTH(N'dbo.Articuloes', N'costo') IS NULL
        ALTER TABLE [dbo].[Articuloes] ADD [costo] DECIMAL(18,2) NOT NULL DEFAULT 0;
    IF COL_LENGTH(N'dbo.Articuloes', N'stock') IS NULL
        ALTER TABLE [dbo].[Articuloes] ADD [stock] INT NOT NULL DEFAULT 0;
    IF COL_LENGTH(N'dbo.Articuloes', N'linea_id') IS NULL
        ALTER TABLE [dbo].[Articuloes] ADD [linea_id] INT NULL;
    IF COL_LENGTH(N'dbo.Articuloes', N'proveedor_id') IS NULL
        ALTER TABLE [dbo].[Articuloes] ADD [proveedor_id] INT NULL;
END

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_dbo.Articuloes_dbo.Lineas_linea_id')
BEGIN
    ALTER TABLE [dbo].[Articuloes] WITH CHECK
    ADD CONSTRAINT [FK_dbo.Articuloes_dbo.Lineas_linea_id]
    FOREIGN KEY([linea_id]) REFERENCES [dbo].[Lineas] ([id]);
END

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_dbo.Articuloes_dbo.Proveedors_proveedor_id')
BEGIN
    ALTER TABLE [dbo].[Articuloes] WITH CHECK
    ADD CONSTRAINT [FK_dbo.Articuloes_dbo.Proveedors_proveedor_id]
    FOREIGN KEY([proveedor_id]) REFERENCES [dbo].[Proveedors] ([id]);
END

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_linea_id' AND object_id = OBJECT_ID(N'dbo.Articuloes'))
BEGIN
    CREATE NONCLUSTERED INDEX [IX_linea_id] ON [dbo].[Articuloes] ([linea_id]);
END

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_proveedor_id' AND object_id = OBJECT_ID(N'dbo.Articuloes'))
BEGIN
    CREATE NONCLUSTERED INDEX [IX_proveedor_id] ON [dbo].[Articuloes] ([proveedor_id]);
END
");
        }

        public override void Down()
        {
            // Intentionally left empty to avoid data loss.
        }
    }
}
