CREATE DATABASE sistema_jogadores;

USE sistema_jogadores;

CREATE TABLE jogadores (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    posicao VARCHAR(50) NOT NULL,
    numero_camisa INT NOT NULL
);