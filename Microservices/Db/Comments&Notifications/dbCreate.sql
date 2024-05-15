        CREATE DATABASE CommentsDB;
        GO

        USE CommentsDB;
        GO

        CREATE TABLE Comments (
                                  CommentID INT PRIMARY KEY IDENTITY(1,1),
                                  TaskID INT,
                                  UserID INT,
                                  CommentText NVARCHAR(MAX),
                                  CreatedAt DATETIME DEFAULT GETDATE()
        );
        GO


-- Скрипт для создания базы данных и таблиц для микросервиса Notifications
        CREATE DATABASE NotificationsDB;
        GO

        USE NotificationsDB;
        GO

        CREATE TABLE Notifications (
                                       NotificationID INT PRIMARY KEY IDENTITY(1,1),
                                       UserID INT,
                                       NotificationText NVARCHAR(MAX),
                                       CreatedAt DATETIME DEFAULT GETDATE(),
                                       IsRead BIT DEFAULT 0
        );
        GO