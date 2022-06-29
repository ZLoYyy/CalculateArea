USE [DBTest]
GO
/****** В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
 Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.  ******/


/*Предположим имеются таблицы, наполненные некоторыми данными*/
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	PRIMARY KEY ([ID])

CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	PRIMARY KEY ([ID])

/*Так же имеется промежуточная таблица, наполненная данными*/
CREATE TABLE [dbo].[ProdutCategory](
	[ProductID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL
) ON [PRIMARY]

/*Сам запрос*/
  SELECT P.Name, C.Name 
	  FROM Products AS P
	  LEFT JOIN DBTest.[dbo].ProdutCategory AS PC ON P.ID = PC.ProductID
	  LEFT JOIN DBTest.dbo.Categories AS C ON C.ID = PC.CategoryID
