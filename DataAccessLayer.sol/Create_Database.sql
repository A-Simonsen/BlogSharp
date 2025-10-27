USE BlogSharp;
GO

-- Authors
CREATE TABLE dbo.Author (
  Id           int IDENTITY(1,1) PRIMARY KEY,
  Email        nvarchar(100) NOT NULL,
  PasswordHash nvarchar(max) NOT NULL,
  BlogTitle    nvarchar(50) NOT NULL,
  CONSTRAINT UQ_Author_Email UNIQUE (Email)
);
GO

-- Blog posts
CREATE TABLE dbo.BlogPost (
  Id           int IDENTITY(1,1) PRIMARY KEY,
  Title        nvarchar(50) NOT NULL,
  TextBody     nvarchar(max) NOT NULL,
  CreationDate datetime2(7) NOT NULL,
  FK_Author_Id int NOT NULL,
  CONSTRAINT FK_BlogPost_Author FOREIGN KEY (FK_Author_Id)
    REFERENCES dbo.Author(Id)
);
GO