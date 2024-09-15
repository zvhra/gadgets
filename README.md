**Gadget Information System**

**Overview**

This program is designed to manage a collection of gadgets from various companies. It allows users to add, view, search, edit, and filter gadgets by company and review score. The program makes use of object-oriented principles, including inheritance and enumeration, to represent gadgets from different manufacturers.

**Features**
Add New Gadget: Allows the user to input details about a new gadget and add it to the system.
View All Gadgets: Displays a list of all gadgets currently in the system, along with their name, description, review, and associated company.
Filter by Company: Lets the user filter and view gadgets by specific companies (Apple, Samsung, Google, OnePlus, Sony).
Filter by Review: Allows the user to search for gadgets based on review ratings.
Edit Gadget Details: Provides the ability to edit the details (name, description, review) of an existing gadget in the system.
Exit Program: Offers the user an option to exit the system, with a confirmation prompt to avoid accidental exits.

**Gadget Types**
The program supports the following gadget types, represented by an enumeration:
1. Apple
2. Samsung
3. Google
4. OnePlus
5. Sony

**How to Run the Program**
Ensure you have .NET installed on your machine.
Compile and run the program using the following commands:

csc Program.cs
Program.exe


**Program Menu**
When the program starts, you will be presented with the following options:

**Add New Gadget: **
Add a new gadget by specifying the gadget's type, name, description, and review score.
View All Gadgets: Display all gadgets stored in the system.
View Gadgets by Company Name: Filter gadgets based on their company (Apple, Samsung, Google, OnePlus, or Sony).
View Gadgets by Review: Search gadgets based on their review rating (from 1 to 5).
Edit Existing Gadget: Edit the details of an existing gadget.
Exit: Exit the program.

**Example Usage**
Upon running the program, you'll be prompted to choose an option from the menu. 

**For example:**
1. Selecting 1 (Add New Gadget) allows you to input a gadget's details.
2. Selecting 2 (View All Gadgets) will display a list of all gadgets currently stored in the system.

**Adding a Gadget**
When prompted to add a new gadget, enter the following details:

**Gadget Type: **
Choose between Apple, Samsung, Google, OnePlus, or Sony (by entering a number between 1-5).
**Gadget Name: **
The name of the gadget (e.g., "iPhone 13").
**Description:**
A short description or grade (e.g., "Grade A").**
Review:**
A rating between 1 and 5 (e.g., "5").

**Viewing Gadgets**
**When you select the option to view gadgets:**

**View All Gadgets:** 
Displays a list of all gadgets.
**Filter by Company:** 
Allows you to view gadgets by company type (e.g., only Apple or Samsung gadgets).
**Filter by Review:**
Lets you search gadgets based on review score (e.g., gadgets with a review of "5").

**Code Structure**
Gadget.cs: Defines the base class Gadget and includes properties like Name, Description, Review, and Company. The class also defines methods to display gadget information.
Company-Specific Classes: These are classes derived from the base Gadget class for each company (Apple, Samsung, Google, OnePlus, Sony).
GadgetType Enum: Defines the enumeration for supported companies.
GadgetSystem.cs: Contains the main logic, including the menu system and operations for adding, viewing, and editing gadgets.

**Future Enhancements**
Sorting Gadgets: Add functionality to sort gadgets by name or review score.
Saving and Loading Data: Implement persistence to save the gadget list to a file for future sessions.
More Gadget Attributes: Include additional fields such as price, release date, and specifications.

**License**
This project is open-source and available for modification under the MIT License.
