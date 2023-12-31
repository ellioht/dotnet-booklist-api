# Booklist API using .NET and MongoDB Atlas

<strong>
This API project is a Booklist where users can get, post, update, and delete books from the MongoDB database.
</strong>

## Front End

The front end uses Vue

## Project Setup

```sh
npm install
```

### Compile and Hot-Reload for Development

```sh
npm run dev
```

### Compile and Minify for Production

```sh
npm run build
```

## API Documentation

Steps taken to create this API.

### Step 1: Create Poject

- Run "dotnet new webapi -o ." to create new web api project in current folder
- Install dependencies "dotnet add package {package name}"
- MongoDB.Driver for connecting to MongoDB Atlas
- DotNetEnv for storing our MongoDB connection URI within a .env file to keep it hidden on GitHub

### Step 2: MongoDB Connection

- Define MongoDB settings in appsettings.json
- The ConnectionString will come from the .env file that is ignored on github within the .gitignore file
- Create MongoDBSettings.cs class and add database settings ready to be linked in Program.cs

### Step 3: Create database model

- Create new folder called Models and add a C# class file called book
- The book model has an Id, bookname, author, and isread

### Step 4: Services

- Create MongoDB service to get the booklist collection
- Create one simple Get route service that returns all books in the DB

### Step 5: Controllers

- Create BooklistController within Controllers folder
- This file holds all the Http requests and points them to the service code

### Step 6: Program

- Add a line of code to link the MongoDBSettings class to the appsettings.json
- Add a line of code to add the BooklistService to the application so it can be used

### Step 7: Testing

- Before adding more routing the API will be tested to see it the MongoDB connection is working with the .env file
- Run application using "dotnet run"
- Because the api project was made using dotnet webapi we can go to the swagger interface to test this "localhost:0000/swagger"

### Step 7: Front End

- Run "npm create vue@latest" in app directory
- Install cors into the .NET backend to accept http requests from our front end
