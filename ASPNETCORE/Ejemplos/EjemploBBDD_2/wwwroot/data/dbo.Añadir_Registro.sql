CREATE PROCEDURE Añadir_Registro
	@Nombre nvarchar(50),
	@Edad int
	
AS
BEGIN
	DECLARE @Id int;
	SELECT @Id=COALESCE(MAX(Id),0)+1 
	FROM Datos;

	INSERT INTO Datos(Id,Nombre,Edad) VALUES(@Id,@Nombre,@Edad);

	

END