# Child Care App
This app akes it easy for parent to be able to monitor the activities of their children as they are able to login and check through the activity 
calender to see what activities their child have done.
On the other side the Attendants are able to login and register children and also logs activities of every child.

#Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for
notes on how to deploy the project on a live system.

Prerequisites
What things you need to install the software and how to install them

Visual Studio 2019 updated to support Xamarin.forms 4

Installing
After opening the project in your Visual Studio go to the 
Nugget Package Section and Update all Nuget Packages and Install the neccesary

Coding
Using MVVM model
also folders included 
Fonts \folder: where the font file is located for the beautification  of the UI and the format is in .ttf
Helpers \\ Folder : where the IconFont.cs file is located this is the C# cods for the fontAwesome images transformed to C# codes
Views \\ Folder: where all views are located with the .xaml extension
Model \\ folder: where the data ar ebeing done
in the Model - Attendant.cs is where the properties of the Attendant are being decleared in public 
AttendantLogin.cs where the properties of the Attendant login objects are decleared in public
ChildDailyEvaluation.cs where the properties associated to the child daily activites are set to public which includes Medication and so on
ParentLogin.cs where the Properties of the parent login is decleared in public 
RegisterChild.cs - where the properties of the registration page for the child is set also in public

ViewModels
BaseViewModel.cs
On this clss we inherit the  INotifyPropertyChanged which notifies the Video model on any change that occurs on the view
