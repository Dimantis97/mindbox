/*Т.к. обычно данные, имеющие связи многие-ко-многим хранятся в 2-х таблицах, связанных промежуточной, создал 3 таблицы:
prods - продукты;
cats - категории;
links - связующая таблица.*/
CREATE TABLE prods(
  id int PRIMARY KEY,
  prod varchar(10));
CREATE TABLE cats(
  id int PRIMARY KEY,
  cat varchar(10));
CREATE TABLE links(
  id int PRIMARY KEY,
  prod int not NULL, 
  cat int not NULL, 
  CONSTRAINT fk_prod FOREIGN KEY(prod) REFERENCES prods(id),
  CONSTRAINT fk_cat FOREIGN key(cat) REFERENCES cats(id)
  );

--сам запрос на получение всех пар продукт-категория
select prods.prod, cats.cat FROM
links 
    LEFT JOIN prods on prods.id = links.prod
    LEFT JOIN cats on cats.id = links.cat;
