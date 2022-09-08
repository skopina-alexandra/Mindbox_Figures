# Задание №2
```
CREATE TABLE CATEGORIES (
Id INT NOT NULL,
 Name TEXT NOT NULL,
  PRIMARY KEY(Id)
);

CREATE TABLE PRODUCTS (
Id INT NOT NULL,
 Name TEXT NOT NULL,
  PRIMARY KEY(Id),
);

CREATE TABLE CATEGORIES_OF_PRODUCTS (
  Id INT NOT NULL,
CategoryId INT NOT NULL,
ProductId INT NOT NULL,
  FOREIGN KEY(CategoryId) REFERENCES CATEGORIES(Id),
    FOREIGN KEY(ProductId) REFERENCES PRODUCTS(Id),
  PRIMARY KEY(Id)
);

INSERT INTO CATEGORIES (Name,Id) VALUES ('italian',1);
INSERT INTO CATEGORIES (Name,Id) VALUES ('mexican',2);
INSERT INTO CATEGORIES (Name,Id) VALUES ('french',3);
INSERT INTO CATEGORIES (Name,Id) VALUES ('vegan',4);
INSERT INTO CATEGORIES (Name,Id) VALUES ('gluten free',5);
INSERT INTO CATEGORIES (Name,Id) VALUES ('sugar free',6);

INSERT INTO PRODUCTS (Name,Id) VALUES ('pasta carbonara',1);
INSERT INTO PRODUCTS (Name,Id) VALUES ('veggy quesadilla',2);
INSERT INTO PRODUCTS (Name,Id) VALUES ('banana pancakes',3);
INSERT INTO PRODUCTS (Name,Id) VALUES ('pizza margarita',4);
INSERT INTO PRODUCTS (Name,Id) VALUES ('onion soup',5);
INSERT INTO PRODUCTS (Name,Id) VALUES ('chicken udon',6);

INSERT INTO CATEGORIES_OF_PRODUCTS (CategoryId,ProductId,Id) VALUES (1,1,1);
INSERT INTO CATEGORIES_OF_PRODUCTS (CategoryId,ProductId,Id) VALUES (2,2,2);
INSERT INTO CATEGORIES_OF_PRODUCTS (CategoryId,ProductId,Id) VALUES (1,4,3);
INSERT INTO CATEGORIES_OF_PRODUCTS (CategoryId,ProductId,Id) VALUES (5,3,4);
INSERT INTO CATEGORIES_OF_PRODUCTS (CategoryId,ProductId,Id) VALUES (3,5,5);
INSERT INTO CATEGORIES_OF_PRODUCTS (CategoryId,ProductId,Id) VALUES (6,3,6);
INSERT INTO CATEGORIES_OF_PRODUCTS (CategoryId,ProductId,Id) VALUES (4,2,7);

SELECT PRODUCTS.Name AS ProductName, 
PRODUCTS.Id AS ProductId, 
CATEGORIES_OF_PRODUCTS.Id AS CategoryID 
INTO tempProductAndCategories
FROM PRODUCTS LEFT JOIN CATEGORIES_OF_PRODUCTS
ON PRODUCTS.Id = CATEGORIES_OF_PRODUCTS.ProductId;

SELECT tempProductAndCategories.ProductName AS ProductName, 
CATEGORIES.Name AS CategoryName
FROM tempProductAndCategories LEFT JOIN CATEGORIES
ON tempProductAndCategories.CategoryId = CATEGORIES.Id;

DROP TABLE tempProductAndCategories;
```
