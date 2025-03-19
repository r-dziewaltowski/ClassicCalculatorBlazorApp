# Classic Calculator Blazor application
A simple calculator web application giving a feel of using an old school physical calculator device.

## Table of Contents
- [Description](#description)
- [Features](#features)
- [Usage](#usage)
- [License](#license)

## Description
It's a Blazor Single Page Application (SPA) which is also a Progressive Web Application (PWA) which means that it can be installed on any device (e.g. Windows desktop, Android mobile) like a native app.

This project is just a frontend and for internal calculator logic it uses my ClassicCalculator Nuget package. Thanks to that it is focused solely on the presentation layer, not on the business logic.

## Features
The application provides the functionality of a simple calculator with a display showing just one number and the following buttons:
- Digits (0-9)
- Decimal point (.)
- Toggle sign (+/-)
- Add (+)
- Subtract (-)
- Multiply (*)
- Divide (/)
- Calculate/Equals (=)
- Percent (%)
- Sqaure root (√)
- Clear (C)

The behaviour follows quite closely my own physical calculator device.

## Usage
```bash
git clone https://github.com/r-dziewaltowski/ClassicCalculatorBlazorApp.git
cd .\ClassicCalculatorBlazorApp\
```

The application is deployed and avaialble at the following address: https://classiccalculator.onrender.com/. Plase note that when you try to access it it may be asleep and needs around a minute to wake up. It's a Progressive Web Application (PWA) which means that it can be installed on any device (e.g. Windows desktop, Android mobile) like a native app.

If you prefer to run it locally there's two options:
- Run in Docker container:
```bash
docker-compose up --build
```
Access via http://localhost/ in your browser
- Run directly:
```bash
dotnet run --project .\src\ClassicCalculatorBlazorApp\
```
Access via http://localhost:5116/ or https://localhost:7201 in your browser

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

