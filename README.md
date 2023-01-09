# CustomRenderers MAUI

I want to create a CustomDatePicker that supports nullable date and also provides Clear action button. So that if user want to clear the selection they can. I have did R&D and found that we can use Xamarin.Forms renderes in .net maui from here: 
https://github.com/dotnet/maui/wiki/Using-Custom-Renderers-in-.NET-MAUI

For same requirements I have got a solution and sample project posted by Charlin Agramonte (below link): 
https://xamgirl.com/clearable-datepicker-in-xamarin-forms/

Implemented same logic in .Net MAUI project. It does work fine in Android, but in iOS custom renderer this.Control gives null. 

Question is MAUI supports Custom Renderers from Xamarin.Forms or not? If yes, then why it's not working on iOS. Because it's not for this control only it will return Null for all other controls as well. 
