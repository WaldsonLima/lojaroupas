# lojaroupas
Faça os seguintes comandos no terminal:
cd Loja.Web
dotnet ef migrations add nomeDaMigration
dotnet ef database update

Depois vá ao banco e ative o script abaixo:

INSERT INTO "Categorias" ("Nome") VALUES 
('Inverno'),
('Verão'),
('Primavera'),
('Outono');
SELECT * FROM "Categorias";

INSERT INTO "TipoUsuaris" ("Nome") VALUES 
('Gerente'),
('Funcionario'),
('Cliente');
SELECT * FROM "TipoUsuaris";

INSERT INTO "Produtos" ("Nome", "Preco", "CategoriaId", "Descricao", "UrlImg") VALUES 
('Luva Totoro', 29.9, 1, 'Luva muito legal do Totoro.', '~/img/luva-totoro.jpg'),
('Luva Shingeki', 29.9, 1, 'Luva muito linda de Shingeki.', '~/img/luva-shingeki.jpg'),
('Camisa Totoro', 69.9, 2, 'Camisa muito fofa do Totoro.', '~/img/camisa-totoro.jpg'),
('Camisa Chihiro', 69.9, 2, 'Camisa muito estilosa da Chihiro.', '~/img/camisa-chihiro.jpg'),
('Blusa Totoro', 99.9, 3, 'Blusa muito quentinha do Totoro', '~/img/blusa-totoro.jpg'),
('Blusa Chihiro', 99.9, 3, 'Blusa muito confortável da Chihiro.', '~/img/blusa-chihiro.jpg'),
('Chapéu Totoro', 49.9, 4, 'Chapéu muito bonito do Totoro.', '~/img/chapeu-totoro.jpeg'),
('Chapéu Chihiro', 49.9, 4, 'Chapéu muito interessante da Chihiro.', '~/img/chapeu-chihiro.jpg'),
('Mochila Studio Ghibli', 39.9, 4, 'Mochila muito doida do Studio Ghibli.', '~/img/mochila-studio.jpg');
SELECT * FROM "Produtos";

INSERT INTO "Usuarios" ("Nome", "Email", "Senha", "TipoUsuarioId") VALUES 
('Waldson', 'waldsonh@gmail.com', 'limasmn', 1),
('Sthefani', 'sthefani@gmail.com', 'sthefanilovelima', 2),
('Chico', 'chico@gmail.com', 'chichi', 2),
('Tenzen', 'tenzen@gmail.com', 'tenzendoar', 3);
SELECT * FROM "Usuarios";