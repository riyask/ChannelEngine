## Channel Engine Assesment
Implemented below functionalities using ChannelEngine API
1.	Fetch all orders with status IN_PROGRESS from the API 
2.	From these orders, compile a list of the top 5 products sold (product name, GTIN and total quantity), order these by the total quantity sold in descending order
3.	Pick one of the products from these orders and use the API to set the stock of this product to 25.

Technicals
1. ChannelEngineConfiguration - This class library used for basic configurations such as getting api base url based on environment, Reading value from configuration files etc..
2. ChannelEngineBusiness - All business logics are written in this library 
3. ChannelEngineConsole - This is entry point Console application
4. ChannelEngineConsoleTest - Test for console application
5. ChannelEngineWeb - This is entry point Web application
6. ChannelEngineWebTest - Test for web application

Used follwing things to develop this application
1. IDE- Visual Studio 2019
2. .Net 5.0
3. Dependency Injection
4. Async await in ChannelEngineBusiness
5. MSTest Framework and moq for unit testing
