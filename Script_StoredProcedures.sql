--_______________________________________STORE PROCEDURES ACTUALIZAR____________________________________________
USE [ProyectoFinal_BD]
GO

/****** Object:  StoredProcedure [dbo].[spActualizarEmpleado]    Script Date: 25/05/2016 03:48:53 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spActualizarEmpleado]
	@NomEmpA		AS VARCHAR (20),
	@APEmpA			AS VARCHAR (20),
	@AMEmpA			AS VARCHAR (20),
	@FeNacEmpA		AS DATE,
	@FeIngEmpA		AS DATE,
	@IdPuestoA		AS INT,
	@IdSubDA		AS INT,
	@IdRolA			AS INT,
	@ActivoEmpA		AS BIT,
	@Email			AS VARCHAR (50),
	@ContEmp		AS VARCHAR (50),
	@IdEmpA			AS INT
AS
BEGIN
	UPDATE tblEmpleado
	SET
	NomEmp = @NomEmpA,
	APEmp = @APEmpA,
	AMEmp = @AMEmpA,
	FeNacEmp = @FeNacEmpA,
	FeIngEmp = @FeIngEmpA,
	IdPuesto = @IdPuestoA,
	IdSubD = @IdSubDA,
	IdRol = @IdRolA,
	ActivoEmp = @ActivoEmpA,
	Email = @Email,
	ContEmp = @ContEmp
	
WHERE IdEmp = @IdEmpA
END

GO


USE [ProyectoFinal_BD]
GO

/****** Object:  StoredProcedure [dbo].[spActualizarProveedor]    Script Date: 25/05/2016 03:49:04 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spActualizarProveedor]
	@NomProvA		AS VARCHAR (20),
	@ActivoProvA		AS BIT,
	@IdProvA			AS INT
AS
BEGIN
	UPDATE tblProveedor
	SET
	NomProv = @NomProvA,
	ActivoProv = @ActivoProvA
	WHERE IdProv = @IdProvA
END

GO


USE [ProyectoFinal_BD]
GO

/****** Object:  StoredProcedure [dbo].[spActualizarSubDire]    Script Date: 25/05/2016 03:49:13 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spActualizarSubDire]
	@NomSDA		AS VARCHAR (20),
	@ActivoSDA		AS BIT,
	@IdSDA			AS INT
AS
BEGIN
	UPDATE tblSubdireccion
	SET
	NomSubD = @NomSDA,
	ActivoSD = @ActivoSDA
	WHERE IdSubD = @IdSDA
END

GO

--_______________________________________STORE PROCEDURES ELIMINAR____________________________________________

USE [ProyectoFinal_BD]
GO

/****** Object:  StoredProcedure [dbo].[spEliminarEmpleado]    Script Date: 25/05/2016 03:51:33 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spEliminarEmpleado]
	@IdEmpE		AS INT
AS
BEGIN
		UPDATE tblEmpleado
		SET ActivoEmp = 0
		WHERE IdEmp = @IdEmpE
END

GO


USE [ProyectoFinal_BD]
GO

/****** Object:  StoredProcedure [dbo].[spEliminarProveedor]    Script Date: 25/05/2016 03:51:39 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spEliminarProveedor]
	@IdProvE	AS INT
AS
BEGIN
		UPDATE tblProveedor
		SET ActivoProv = 0
		WHERE IdProv = @IdProvE
END

GO


USE [ProyectoFinal_BD]
GO

/****** Object:  StoredProcedure [dbo].[spEliminarSubDire]    Script Date: 25/05/2016 03:51:48 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spEliminarSubDire]
	@IdSubDE	AS INT
AS
BEGIN
		UPDATE tblSubdireccion
		SET ActivoSD = 0
		WHERE IdSubD = @IdSubDE
END

GO

--_______________________________________STORE PROCEDURES AGREGAR_____________________________________________

USE [ProyectoFinal_BD]
GO

/****** Object:  StoredProcedure [dbo].[spNuevaSubDire]    Script Date: 25/05/2016 03:52:25 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spNuevaSubDire]
		@NomSubD		as varchar (20),
		@IdEmpEncar			as int,
		@ActivoSD		as bit
AS
BEGIN
	INSERT INTO tblSubdireccion (
		NomSubD,
		IdEmpEncar,
		ActivoSD
	)
	Values(
		@NomSubD,
		@IdEmpEncar,
		@ActivoSD	
	)
END

GO


USE [ProyectoFinal_BD]
GO

/****** Object:  StoredProcedure [dbo].[spNuevoEmpleado]    Script Date: 25/05/2016 03:52:29 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spNuevoEmpleado] 
	@NomEmp			AS VARCHAR (20),
	@APEmp			AS VARCHAR (20),
	@AMEmp			AS VARCHAR (20),
	@FeNacEmp		AS DATE,
	@FeIngEmp		AS DATE,
	@IdPuesto		AS INT,
	@IdSubD			AS INT,
	@IdRol			AS INT,
	@ActivoEmp		AS BIT,
	@ContEmp		AS VARCHAR(50),
	@Email			AS VARCHAR(50)
AS
BEGIN
	INSERT INTO tblEmpleado (
		NomEmp,
		APEmp,
		AMEmp,
		FeNacEmp,
		FeIngEmp,
		IdPuesto,
		IdSubD,
		IdRol,
		ActivoEmp,
		ContEmp,
		Email	
		)
	VALUES (
		@NomEmp,
		@APEmp,
		@AMEmp,
		@FeNacEmp,
		@FeIngEmp,
		@IdPuesto,
		@IdSubD,
		@IdRol,
		@ActivoEmp,	
		@ContEmp,
		@Email	
	)
END
GO


USE [ProyectoFinal_BD]
GO

/****** Object:  StoredProcedure [dbo].[spNuevoProveedor]    Script Date: 25/05/2016 03:52:35 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[spNuevoProveedor]
	@NomProv			AS VARCHAR (20),
	@ActivoProv			AS INT
	
AS
BEGIN
	INSERT INTO tblProveedor (
		NomProv,
		ActivoPRov
	)
	VALUES (
		@NomProv,
		@ActivoProv
		)
END

GO
