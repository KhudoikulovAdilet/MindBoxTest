
//        CREATE TABLE Products(
//            Id INT PRIMARY KEY,
//                	"ProductName" TEXT
        

//        );
//        INSERT INTO Products
//        VALUES
//            (1, '1984'),
//        (2, 'Mercedes e220'),
//        (3, 'Samsung galaxy s22 ultra');
//                CREATE TABLE Categories(
//            Id INT PRIMARY KEY,
//            "CategoryName" TEXT
//            );

//        INSERT INTO Categories
//        VALUES
//        (1, 'Books'),
//        (2, 'Cars'),
//        (3, 'Gifts');
//        CREATE TABLE ProductCategories(
//ProductId INT FOREIGN KEY REFERENCES Products(Id),
//CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
//PRIMARY KEY (ProductId, CategoryId)
//);
//        INSERT INTO ProductCategories
//VALUES
//(1, 1),
//(2, 3),
//(3, 3);

//SELECT P."ProductName", C."CategoryName"
//FROM Products P
//LEFT JOIN ProductCategories PC
//ON P.Id = PC.ProductId
//LEFT JOIN Categories C
//ON PC.CategoryId = C.Id;
