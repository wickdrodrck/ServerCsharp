CREATE TABLE [dbo].[Ciclos] (
    [Codigo] NCHAR(10) NOT NULL,
    [Siglas] NCHAR(10) NOT NULL,
    [Nombre] NVARCHAR(50) NOT NULL,
    [Cursos] INT NOT NULL,
    [Ciclo] NCHAR(10) NOT NULL,
    [Curso] INT NOT NULL,
    [Aula] NVARCHAR(50) NULL,

    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);
