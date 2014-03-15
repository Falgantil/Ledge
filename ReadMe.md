Ledge
====================
A portal to Logitech G-Series LCD through Node.Js
___
NOTE: This library was developed using a Logitech G510 Gaming Keyboard.
___

Use this library for accessing, and easier usable communication with your Logitech G-Series keyboard LCD screen, using NodeJs.
___
RunMe.Js
---
Awaits for console input, and after each line sent (Enter pressed), sets the text on the LCD keyboard to whatever you entered. This loops through each line until finishing line 4, and resets to line 1, continuing.

___
Usages
---
___
* Running a webserver on your own PC?

Implement this, and make your keyboard write a message every time an error occurs, for minimum downtime.
___
* Like money, but tired of checking every now and then to see if any transactions happens on your webserver?

Implement this, and have it send a message every time a transaction occurs.

___
* Basically usable for any kind of temporary and/or constant notification in NodeJs.
___
Personally I'm using only the C# wrapper in an application that reports constant GPU and CPU performance & temperatures.

___
Libraries & Crucial DLLs
---

* [LogitechWrapper.DLL](https://github.com/Falgantil/LogitechWrapper "LogitechWrapper"): Used to communicate with the keyboard.
* LogitechLcd.DLL: Used to communicate with the Logitech G-Series keyboards.
* [Edge](http://tjanczuk.github.io/edge/ "Edge"): The Edge JS library is an extension available in NodeJs through the Package Manager, allowing easy access to the entire .Net library. This is used to perform all the invoking to the .Net libraries.
* Ledge.Net.DLL: Nothing more than a singleton, representing an instance of the Lcd class from Logitech Wrapper. The reason it needs to be a singleton is so that the reference will be preserved between different calls from NodeJs.

___
*NOTE: I TAKE NO RESPONSIBILITY FOR DAMAGES THAT MAY BE CAUSED BY USE OF THIS PROGRAM.*