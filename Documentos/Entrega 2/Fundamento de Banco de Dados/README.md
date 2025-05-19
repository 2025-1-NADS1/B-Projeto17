Modelagem física das tabelas

![image](https://github.com/user-attachments/assets/938df2ee-6788-4114-b43f-87aee867f7a8)  
CREATE TABLE Usuarios (  
    id INT PRIMARY KEY AUTO_INCREMENT,  
    nome_usuario VARCHAR(50) NOT NULL,  
    senha VARCHAR(50) NOT NULL  
);  


![image](https://github.com/user-attachments/assets/a60a3aeb-7b75-43c8-bf3d-24e424e9fa72)  

CREATE TABLE MonitoramentoAmbiental (  
    id INT PRIMARY KEY AUTO_INCREMENT,  
    sensor_id INT NOT NULL,  
    timestamp DATETIME NOT NULL,  
    temperatura FLOAT NOT NULL,  
    umidade FLOAT NOT NULL  
);  



