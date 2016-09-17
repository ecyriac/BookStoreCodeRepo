IF ( OBJECT_ID('dbo.InsertBook') IS NOT NULL ) 
   DROP PROCEDURE dbo.sp_Students_INS_byPK
GO

CREATE PROCEDURE dbo.InsertBook
       @Isbn                           VARCHAR(25)      = NULL  , 
       @Title                          VARCHAR(36)              , 
       @Publisher                      VARCHAR(36)      = NULL  , 
       @AuthorshipDetails              VARCHAR(36)      = NULL               
AS 
BEGIN 
     SET NOCOUNT ON 

		  Insert Into Book ( 
Created,
Isbn,
Title,
Publisher,
AuthorshipDetails
)
VALUES(
CURRENT_TIMESTAMP,
@Isbn, 
@Title, 
@Publisher, 
@AuthorshipDetails
)


END 

GO