CREATE TABLE [dbo].[Alumnos] (
    [DNI] NCHAR(9) NOT NULL,
    [ONT] NVARCHAR(50) NOT NULL,
    [Nombre] NVARCHAR(80) NOT NULL,
    [Apellidos] NVARCHAR(80) NOT NULL,
    [Telefono] INT NOT NULL,
    [Edad] INT NOT NULL,
    [Ciclo] NCHAR(10) NOT NULL,
    [Curso] INT IDENTITY(1, 1) NOT NULL,
    PRIMARY KEY CLUSTERED ([DNI] ASC),
    CONSTRAINT [FK_Alumnos_Ciclos] FOREIGN KEY ([Ciclo]) REFERENCES [dbo].[Ciclos] ([Siglas])
);
