# InfraClassify
Solution built for the 2021 Virtual ML.NET Hackathon. Using ML.NET, InfraClassify is a machine learning example for classifying images as type of infrastructure asset.

## Image Model Schema
roads  
railways  
bridges  
tunnels  
water supply  
sewers  
electrical grids   
telecommunications  
buildings  


## Technologies
Project is created with:  
ML.NET
ASP.NET Core  
C# 
HTML
CSS Bootstrap  

## Project status
The project is 'in progress' 


## Projects Documentation
InfraConsoleApp.Train  
-first app to be created. This is where the Visual Studio Model Builder was initated to train the image classification model.  

ImageClassificationInfrastructureMLModel_ConsoleApp1  
-Automative Console App from model builder.  
-.net 5 framework  

ImageClassificationInfrastructureMLModel_WebApi1  
-Web Api made by Model Builder  

ImageClassificationInfraClassify.MyWebApp  
-.net core web app using controller for rest end api  
-web site for infraclassify  

WebAPIClientConsoleApp   
-Console app to communicated with WebApi for batch processing.  
-.net core   
 

   

## Sources  
https://github.com/virtualmlnet/hackathon-2021   

## Scope of functionalities  
basic functions  
* Web app - Simple image online classification  

medium functions  
* Web API - Minimal with no controllers
* Console app for classifying locally 
* Console app for client calling web api  
  
Advance functions  
* integrated with distributed technolgies  


## Installation  

#### Before Running Solution  
Make sure you have all the package downloaded for nuget. Nuget files are not being  
uploaded to github.  

#### Running app options  
There are there main ways in running this app.First, just the web app. Second, using the web api with another app. 
and third, locally with just a console app. 

##### Stand App  
The easist mode will be the single app. There are two projects that can run alone. The web app will give a website 
with a working online image classifier using controllers. The .net 5 console app (ImageClassifierInfrastructureMLModel_ConsoleApp1) is the automated
built project from the Automatic Model Builder from ML.NET and Visual Studio.

##### Multi-App Configuration  
The multi project operations is a little more difficult, expecially since different
configuration can be run including  

-web app and web api  
-web api and web client console app  
-web app, web api, and web client console app  









