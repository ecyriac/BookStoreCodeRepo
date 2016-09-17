CREATE TABLE Book
(
BookId UNIQUEIDENTIFIER DEFAULT NEWSEQUENTIALID() PRIMARY KEY,
Created datetime2,
Isbn varchar(255),
Title varchar(255),
Publisher varchar(255),
AuthorshipDetails varchar(255)
)