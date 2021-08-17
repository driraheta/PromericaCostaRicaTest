use demo
go


create PROCEDURE sp_updatemake
    @Id int = null,
    @Name varchar(100),
    @Country varchar(150)
AS
BEGIN

set NOCOUNT on

IF @Id is not null
BEGIN
    UPDATE Make 
    SET name = @Name, 
    country = @Country 
    WHERE id = @Id
END

END

GO

create PROCEDURE sp_deletepattern
    @Id int = null
AS
BEGIN

set NOCOUNT on

IF @Id is not null
BEGIN
    DELETE
    FROM Pattern 
    WHERE id = @Id
END


END


GO


