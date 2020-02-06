Thomas Chung's Portfolio
==================================================
Molar Mass Calculator

This project is was originally an assignment in a programming class I took at NAIT.

The major aspects of programming thats are in this projects are:
- Collections
- Regex and user input
- LINQ statements
- Reading data from an outside source

This assignment was a pair project done with another colleague; meaning that I can
not take 100% credit of this project. Taking in element data from its prescribed CSV
sheet, Regex application from user input, and LINQ statements pull and display
current specified elements are of my own work. While all of the UI functionality and
the creation of the CSV sheet was done by my partner.

Everything explained in this documentation will be of the work I have personally done.
Because my partner created the elements CSV sheet manually it was easy to parse out
the data; generating a list of class element holding its name, symbol, atomic number,
and its molar mass. The user will have the ability to type in their own chemical 
formula. Using Regex we will parse out the entire formula (returning false if anything
can not be read), sending all elements into a dictionary to count each element.
Afterwards we will be using a LINQ statement on the dictionary collection of elements
to get and display all the elements used in the chemical formula, its count, and its 
total molar mass weight. Finally using the the LINQ collection to add up the total
molar mass weight of the chemical formula and displaying it for the user.

The buttons provided give the user the ability to sort the entire list of elements in
different ways using a LINQ statement on the CSV element collection.
