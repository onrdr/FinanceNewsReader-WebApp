# Finance News Web App
This is a web application built with ASP.NET Core and Razor Pages that fetches finance news from an external API. 

The app displays the list of news in real-time on the home page.

The app automatically refreshes itself every 60 seconds to ensure the latest news is always displayed.

## Prerequisites
To run this application, you will need the following:

- [.NET Core 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) or later
- An IDE to open the project, modify the code and run the program. (preferably Visual Studio 2022)
- An API key from [Finance Layer](https://apilayer.com/marketplace/financelayer-api)

## Getting Started
### 1. Clone the repository:
```
git clone https://github.com/onrdr/FinansNewsReader-WebApp
```

### 2. Navigate to the project directory:
```
cd FinansNewsReader-WebApp
```

### 3. Open the project in your IDE
```
start FinanceNews.sln
```

### 4. Obtain an API key from FinanceLayer by following these steps:
* Sign up for a [FinanceLayer](https://apilayer.com/marketplace/financelayer-api) account.
* Log in to your account and navigate to the API Access page. 
* Copy the API key 

### 5. Open appsettings.json in the solution 
![soultion](https://user-images.githubusercontent.com/106915107/230788733-4bc038a2-f687-493b-910b-11f9a76810e1.png)

### 6. Paste the key between the double quotes for the "API_KEY" property in the appsettings.json file
![key_section](https://user-images.githubusercontent.com/106915107/230788962-d2c72e4b-0660-4ae6-8d4a-1f3a5b8b6df4.png)

### 7. Run the application. 
You should be able to see the news that you fetch from the news service provider

## Note : The Free Api Key only allows 50 request in a month.  
