IOC implemention on different .Net C# Projects.
Using 'Windsor Castle'

The 'IOC' solution contains 4 projects types that implement IOC using Windsor Castle:
	1.	Web MVC Application
	2.	Console Application
	3.	Windows form
	4.	Class Library
	
Each project has reference to the 'IOC.ClassLibrary' project and calls the 'DemoFunc' function.
Each project create the Windsor Container in the start method of the project.

For any question and comment please contact me.
Hadasa


Castle Windsor is an inversion of control tool.

It can give you objects with pre-built and pre-wired dependencies right in there. An entire object graph created via reflection and configuration rather than the "new" operator.
https://github.com/castleproject/Windsor/blob/master/docs/README.md

