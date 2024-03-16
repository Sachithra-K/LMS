CREATE TABLE LibrarianLogin(
    Username   VARCHAR (50) NOT NULL,
    Password VARCHAR (50) NULL
    
);


CREATE TABLE StudentRegistration (
    StudentId   INT           NOT NULL,
    StudentName VARCHAR (MAX) NOT NULL,
    Address     VARCHAR (MAX) NOT NULL,
    Gender      VARCHAR (MAX) NOT NULL,
    ContactNo   INT           NOT NULL,
    Email       VARCHAR (MAX) NOT NULL
);

CREATE TABLE LecturerRegistration (
    LecturerId   INT           NOT NULL,
    LecturerName VARCHAR (MAX) NOT NULL,
    Address     VARCHAR (MAX) NOT NULL,
    Department   VARCHAR (MAX) NOT NULL,
    Gender      VARCHAR (MAX) NOT NULL,
    ContactNo    INT           NOT NULL,
    Email       VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([LecturerId] ASC)
);

CREATE TABLE AddBook (
    BookId          INT           NOT NULL,
    BookName         VARCHAR (MAX) NOT NULL,
    BookAuthor      VARCHAR (MAX) NOT NULL,
    BookPublisher    VARCHAR (MAX) NOT NULL,
    BookPurchaseDate DATETIME      NOT NULL,
    BookQuantity    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([BookId] ASC)
);

CREATE TABLE CalculateTable (
    MemberId  INT NOT NULL,
    TotalFine INT NOT NULL
);


CREATE TABLE BorrowingBook(
    BookId      INT           NOT NULL,
    BookName    VARCHAR (MAX) NOT NULL,
    MemberId     INT           NOT NULL,
    MemberName  VARCHAR (MAX) NOT NULL,
    DateBorrowed DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([BookId] ASC)
);

CREATE TABLE ReturnBook (
    BookId      INT           NOT NULL,
    BookName    VARCHAR (MAX) NOT NULL,
    MemberId    INT           NOT NULL,
    MemberName  VARCHAR (MAX) NOT NULL,
    DateRetured DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([BookId] ASC)
);

CREATE TABLE StudentLogin (
    [Username]    VARCHAR (50) NOT NULL,
    [Password]    VARCHAR (50) NULL,
    [ComPassword] VARCHAR (50) NULL
);


CREATE TABLE LecturerLogin (
    Username    VARCHAR (50) NOT NULL,
    Password   VARCHAR (50) NULL,
    ComPassword VARCHAR (50) NULL
);


SELECT * FROM  LibrarianLogin;

INSERT INTO LecturerLogin([Username], [Password], [ComPassword] ) 
VALUES ('gayan1', 'password1', 'password1');