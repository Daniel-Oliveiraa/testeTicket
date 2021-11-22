# Instalação
É necessário estar instalado o Docker. Para instalar:

 - **Windows** Faça o Download abaixo:
 [https://docs.docker.com/docker-for-windows/install/](https://docs.docker.com/docker-for-windows/install/)
        
 - **Linux**

          curl -fsSL https://get.docker.com/ | bash

Deve se ter instalado também o Docker Compose.

 - **Windows**
 Para o Windows nas versões Docker Desktop for Windows e Docker Toolbox o Compose já está incluído.
 
 - **Linux**
 
        sudo curl -L "https://github.com/docker/compose/releases/download/1.25.3/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose
        sudo chmod +x /usr/local/bin/docker-compose
        
# Docker-Compose
O arquivo docker-compose.yml localizado na pasta raiz do repositório realiza a subida do servidor sql que abrigará nosso banco de dados para o funcionamento da aplicação.
Para isso precisamos executar o comando:
        docker-compose up -d
atravez do cmd, na pasta raiz do projeto.

#Criação das tabelas
Após a subida do docker podemos abrir a solução do projeto, e com o Pakage Manager Console (localizado na barra de ferramentas, na aba ferramentas - Nuget Package Manager), podemos
abrir a pasta TestTicket com o comando " cd TestTicket " e logo em seguida rodar o comando 
      dotnet ef database update
isso realizará a criação da base de dados e das tabelas utilizadas pela aplicação.      

#Para acessar a aplicação:

**Swagger**
https://localhost:44395/index.html

**Aplicação**
https://localhost:44395/home
