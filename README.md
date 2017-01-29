# DBCompareWithUIWithTestContext
Data Driven Test with Selenium WebDriver and MSTest framework. 
In this project I used TestContext class to link up a unit test infrastructure with data rows from a data source (Oracle DataBase).
TestContext.DataRow Property gets rows one by one and sends them to the test method where I use zero-indexed element from this row (externalid).
Later in my test method I use externalid to get data from DataBase and comperare it to the data from interface.
