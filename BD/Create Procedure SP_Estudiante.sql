Create Procedure SP_Estudiante
@OP tinyint,
@IdEstudiante int = 0, 
@Nombre varchar(50), 
@Ap_Paterno varchar(20) = null, 
@Ap_Materno varchar(20) = null, 
@Matricula varchar(10) = null,
@Correo varchar(150) = null,
@Telefono char(10) = null

As
Begin
    if @OP = 1
    Begin
        Insert into Estudiantes(IdEstudiante, Nombre, Ap_Paterno, Ap_Materno, Matricula, Correo, Telefono)
        Values (@IdEstudiante,  @Nombre, @Ap_Paterno, @Ap_Materno, @Matricula, @Correo, @Telefono)
    END
    if @OP = 2
    Begin
        UPDATE Estudiantes set Nombre=@Nombre.....
        WHERE IdEstudiante = @IdEstudiante
    END
END