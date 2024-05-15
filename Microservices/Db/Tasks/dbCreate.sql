create database TaskDb;
GO


-- Создание таблицы Tasks с учетом завершенных и удаленных задач
CREATE TABLE Tasks (
                       TaskID INT PRIMARY KEY IDENTITY(1,1),
                       Title NVARCHAR(100) NOT NULL,
                       Description NVARCHAR(MAX),
                       DueDate DATETIME,
                       CreatedAt DATETIME DEFAULT GETDATE(),
                       Status NVARCHAR(50) NOT NULL DEFAULT 'Open',
                       Priority NVARCHAR(50) NOT NULL DEFAULT 'Normal'
);
GO

-- Таблица для хранения завершенных задач
CREATE TABLE CompletedTasks (
                                TaskID INT PRIMARY KEY,
                                CompletedAt DATETIME DEFAULT GETDATE(),
                                FOREIGN KEY (TaskID) REFERENCES Tasks(TaskID) ON DELETE CASCADE
);
GO

-- Таблица для хранения удаленных задач
CREATE TABLE DeletedTasks (
                              TaskID INT PRIMARY KEY,
                              DeletedAt DATETIME DEFAULT GETDATE(),
                              FOREIGN KEY (TaskID) REFERENCES Tasks(TaskID) ON DELETE CASCADE
);
GO
