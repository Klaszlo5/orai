CREATE DATABASE papirgyujtes
CHARACTER SET utf8
COLLATE hu_HU.UTF8;

USE papirgyujtes;

CREATE TABLE tanulok (
    tazon INT PRIMARY KEY,
    nev VARCHAR(255) NOT NULL,
    osztaly VARCHAR(10) NOT NULL
);

CREATE TABLE leadasok (
    sorsz INT PRIMARY KEY,
    tanulo INT,
    idopont DATE NOT NULL,
    mennyiseg INT NOT NULL,
    FOREIGN KEY (tanulo) REFERENCES tanulok(tazon)
);