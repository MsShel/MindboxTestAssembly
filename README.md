#### Часть 1

Небходимо написать на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Дополнительно к работоспособности оценивается:  
Юнит-тесты  
Легкость добавления других фигур  
Вычисление площади фигуры без знания типа фигуры в compile-time  
Проверку на то, является ли треугольник прямоугольным  

#### Часть 2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Предположим, у нас есть три таблицы:

`Products` — таблица продуктов, содержащая `ProductID` `ProductName`  
`Categories` — таблица категорий, содержащая `CategoryID` `CategoryName`  
`ProductCategories` — таблица связей продуктов и категорий, содержащая `ProductID` `CategoryID`  
```sql
SELECT 
    product.ProductName,
    category.CategoryName
FROM 
    Products product
LEFT JOIN 
    ProductCategories productCategory ON product.ProductID = productCategory.ProductID
LEFT JOIN 
    Categories category ON productCategory.CategoryID = category.CategoryID
ORDER BY 
    product.ProductName, category.CategoryName;
```
