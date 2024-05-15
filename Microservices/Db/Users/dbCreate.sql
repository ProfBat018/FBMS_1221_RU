CREATE DATABASE UsersDB;
GO;


-- Создание таблицы Users
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    PasswordHash NVARCHAR(MAX) NOT NULL, -- Хэшированный пароль
    Email NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- Таблица для хранения секретов JWT
CREATE TABLE JWTSecrets (
    SecretID INT PRIMARY KEY IDENTITY(1,1),
    Secret NVARCHAR(500) NOT NULL -- Секретный ключ JWT
);
GO

-- Возможно, таблица для хранения чёрного списка токенов (опционально)
CREATE TABLE BlacklistedTokens (
    TokenID INT PRIMARY KEY IDENTITY(1,1),
    Token NVARCHAR(MAX) NOT NULL, -- Хранимый токен
    BlacklistedAt DATETIME DEFAULT GETDATE() -- Дата добавления в чёрный список
);
GO
