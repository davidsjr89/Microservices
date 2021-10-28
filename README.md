# Microservices

Precisar ter o docker instalado na máquina.

Comando para rodar o projeto, acessando via linha de comando, dentro da raiz do projeto, local aonde se encontra
docker-compose.yml e docker-compose.override.yml

docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d --build

Com esse comando irá rodar docker e baixar todas as imagens e configurar os containers.
para acessar via browser o pgadmin.
Link: localhost:5050
User: admin@admin.com
Password: admin1234

Precisar criar um novo Server.
-- Add New Server

-- General --> Name = DiscountServer

-- Connection
--> Host name/address = discountdb
--> Password = admin1234

SAVE

Depois vai em DiscountServer --> Databases --> DiscountDb --> Schemas --> Tables clicar com o botão direito e Query Tool.
Comando para criar a table

CREATE TABLE Coupon(Id Serial PRIMARY KEY,
	   ProductName VARCHAR(24) NOT NULL,
	   Description TEXT,
	   Amount INT);
