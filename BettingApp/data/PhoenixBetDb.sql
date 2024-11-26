-- Create database
CREATE DATABASE IF NOT EXISTS bettingPhoenix_db;


USE bettingPhoenix_db;

-- Users table
CREATE TABLE Users (
    Code VARCHAR(10) PRIMARY KEY,
    LastName VARCHAR(50) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    Gender ENUM('Masculin', 'Feminin') NOT NULL,
    BirthDate DATE NOT NULL,
    Phone VARCHAR(20) NOT NULL,
    NifCin VARCHAR(20) UNIQUE NOT NULL,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    Balance DECIMAL(10, 2) DEFAULT 0.00,
    Role ENUM('ADMIN', 'USER') DEFAULT 'USER',
    Status ENUM('A', 'S', 'F') DEFAULT 'A',  
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Teams table
CREATE TABLE Teams (
    TeamId INT AUTO_INCREMENT PRIMARY KEY,
    TeamName VARCHAR(100) NOT NULL UNIQUE,
    Country VARCHAR(50) NOT NULL,
    LogoPath VARCHAR(255),
    TypeTeam ENUM('National', 'Club'), 
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Matches table
CREATE TABLE Matches (
    MatchId VARCHAR(15) PRIMARY KEY,
    MatchType ENUM('championnat - ligue national', 'coupe du monde','éliminatoire', 'amical', 'autre') NOT NULL,
    Country VARCHAR(50) NOT NULL,
    MatchDate DATE NOT NULL,
    MatchTime VARCHAR(50) NOT NULL,
    HomeTeamId INT NOT NULL,
    AwayTeamId INT NOT NULL,
    HomeWinOdds DECIMAL(5, 2) NOT NULL,
    DrawOdds DECIMAL(5, 2) NOT NULL,
    AwayWinOdds DECIMAL(5, 2) NOT NULL,
    FinalScore VARCHAR(10) DEFAULT '0:0',
    Status ENUM('N', 'E', 'T', 'A', 'S') DEFAULT 'N',
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (HomeTeamId) REFERENCES Teams(TeamId),
    FOREIGN KEY (AwayTeamId) REFERENCES Teams(TeamId)
);

-- Table des paris
CREATE TABLE Bets (
    BetId VARCHAR(20) PRIMARY KEY,
    UserId VARCHAR(10) NOT NULL,
    BetDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    Status ENUM('PENDING', 'COMPLETED', 'CANCELLED') DEFAULT 'PENDING',
    WinStatus ENUM('PENDING', 'WON', 'LOST') DEFAULT 'PENDING',
    FOREIGN KEY (UserId) REFERENCES Users(Code)
);

-- Table de détails des paris
CREATE TABLE BetDetails (
    BetDetailId INT AUTO_INCREMENT PRIMARY KEY,
    BetId VARCHAR(20) NOT NULL,
    MatchId VARCHAR(15) NOT NULL,
    PredictedTeamWinner INT,
    OddValue DECIMAL(5, 2) NOT NULL,
    WinStatus ENUM('PENDING', 'WON', 'LOST') DEFAULT 'PENDING',
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (BetId) REFERENCES Bets(BetId),
    FOREIGN KEY (MatchId) REFERENCES Matches(MatchId),
    FOREIGN KEY (PredictedTeamWinner) REFERENCES Teams(TeamId)
);

-- Payments table
CREATE TABLE Payments (
    PaymentId INT AUTO_INCREMENT PRIMARY KEY,
    BetId VARCHAR(20) NOT NULL,
    PaymentDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentStatus ENUM('PENDING', 'COMPLETED', 'FAILED') DEFAULT 'PENDING',
    FOREIGN KEY (BetId) REFERENCES Bets(BetId)
);
