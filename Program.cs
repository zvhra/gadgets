using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public enum GadgetType
    {
        Apple = 1,
        Samsung = 2,
        Google = 3,
        OnePlus = 4,
        Sony = 5,
    }

    class Gadget
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Review { get; set; }
        public GadgetType Company { get; set; }

        public Gadget(string name, string description, string review, GadgetType company)
        {
            Name = name;
            Description = description;
            Review = review;
            Company = company;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Company,-12} {Name,-15} {Description,-20} {Review,-6}");
        }
    }

    class Apple : Gadget
    {
        public Apple(string name, string description, string review) : base(name, description, review, GadgetType.Apple) { }
    }

    class Samsung : Gadget
    {
        public Samsung(string name, string description, string review) : base(name, description, review, GadgetType.Samsung) { }
    }

    class Google : Gadget
    {
        public Google(string name, string description, string review) : base(name, description, review, GadgetType.Google) { }
    }

    class OnePlus : Gadget
    {
        public OnePlus(string name, string description, string review) : base(name, description, review, GadgetType.OnePlus) { }
    }

    class Sony : Gadget
    {
        public Sony(string name, string description, string review) : base(name, description, review, GadgetType.Sony) { }
    }

    public class GadgetSystem
    {
        public static void Main(string[] args)
        {
            int choice = 1;
            int gadgetType;

            List<Gadget> gadgets = new List<Gadget>
        {
            new Apple("iPhone 13", "Grade A", "5"),
            new Samsung("Galaxy S21", "Grade A", "4"),
            new Google("Pixel 6", "Grade B", "4"),
            new OnePlus("OnePlus 9", "Grade A", "5"),
            new Sony("Xperia 5", "Grade B", "3")
        };

            while (true)
            {
                Console.WriteLine("\nGadget Information System\n");
                Console.WriteLine("1. Add New Gadget");
                Console.WriteLine("2. View All Gadgets");
                Console.WriteLine("3. View Gadgets by Company Name");
                Console.WriteLine("4. View Gadgets by Review");
                Console.WriteLine("5. Edit Existing Gadget");
                Console.WriteLine("6. Exit");
                Console.Write("\nEnter your choice (1-6): ");

                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("\nInvalid input. Please enter a number between 1 and 6.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select Gadget Type (1: Apple, 2: Samsung, 3: Google, 4: OnePlus, 5: Sony):");
                        if (!int.TryParse(Console.ReadLine(), out gadgetType) || gadgetType < 1 || gadgetType > 5)
                        {
                            Console.WriteLine("Invalid Gadget Type");
                            break;
                        }

                        Console.Write("Enter Gadget Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Description: ");
                        string description = Console.ReadLine();

                        Console.Write("Enter Review 1-5: ");
                        string review = Console.ReadLine();

                        switch ((GadgetType)gadgetType)
                        {
                            case GadgetType.Apple:
                                gadgets.Add(new Apple(name, description, review));
                                break;
                            case GadgetType.Samsung:
                                gadgets.Add(new Samsung(name, description, review));
                                break;
                            case GadgetType.Google:
                                gadgets.Add(new Google(name, description, review));
                                break;
                            case GadgetType.OnePlus:
                                gadgets.Add(new OnePlus(name, description, review));
                                break;
                            case GadgetType.Sony:
                                gadgets.Add(new Sony(name, description, review));
                                break;
                        }

                        Console.WriteLine("Gadget added successfully.");
                        break;

                    case 2:
                        if (gadgets.Count == 0)
                        {
                            Console.WriteLine("No gadgets found.");
                            break;
                        }

                        Console.WriteLine("\nList of Gadgets:\n");

                        Console.WriteLine($"{"Company:",-12} {"Name:",-15} {"Description:",-20} {"Review:",-6}");
                        foreach (var gadget in gadgets)
                        {
                            gadget.DisplayInfo();
                        }

                        break;

                    case 3:
                        Console.WriteLine("Select Company to View Gadgets (1: Apple, 2: Samsung, 3: Google, 4: OnePlus, 5: Sony):");
                        if (!int.TryParse(Console.ReadLine(), out int companySelection) || companySelection < 1 || companySelection > 5)
                        {
                            Console.WriteLine("Invalid selection.");
                            break;
                        }

                        GadgetType selectedCompany = (GadgetType)companySelection;

                        var gadgetsByCompany = gadgets.FindAll(g => g.Company == selectedCompany);

                        if (gadgetsByCompany.Count == 0)
                        {
                            Console.WriteLine($"No gadgets found for {selectedCompany}.");
                        }
                        else
                        {
                            Console.WriteLine($"\nGadgets from {selectedCompany}:\n");
                            foreach (var gadget in gadgetsByCompany)
                            {
                                gadget.DisplayInfo();
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter a number to search for in reviews:");
                        string reviewKeyword = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(reviewKeyword))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid keyword.");
                            break;
                        }

                        var gadgetsByReview = gadgets.FindAll(g => g.Review.IndexOf(reviewKeyword, StringComparison.OrdinalIgnoreCase) >= 0);

                        if (gadgetsByReview.Count == 0)
                        {
                            Console.WriteLine($"No gadgets found containing '{reviewKeyword}' in the review.");
                        }
                        else
                        {
                            Console.WriteLine($"\nGadgets with reviews containing '{reviewKeyword}':\n");
                            foreach (var gadget in gadgetsByReview)
                            {
                                gadget.DisplayInfo();
                            }
                        }
                        break;

                    case 5:
                        if (gadgets.Count == 0)
                        {
                            Console.WriteLine("No gadgets found.");
                            break;
                        }

                        Console.WriteLine("\nSelect a gadget to edit:\n");
                        for (int i = 0; i < gadgets.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {gadgets[i].Company} - Name: {gadgets[i].Name}, Description: {gadgets[i].Description}, Review: {gadgets[i].Review}");
                        }

                        Console.Write("Enter the number of the gadget to edit: ");
                        if (!int.TryParse(Console.ReadLine(), out int gadgetIndex) || gadgetIndex < 1 || gadgetIndex > gadgets.Count)
                        {
                            Console.WriteLine("Invalid selection.");
                            break;
                        }

                        Gadget selectedGadget = gadgets[gadgetIndex - 1];

                        Console.Write("Enter new Gadget Name (press Enter to keep current name): ");
                        string newName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newName))
                        {
                            selectedGadget.Name = newName;
                        }

                        Console.Write("Enter new Description (press Enter to keep current description): ");
                        string newDescription = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newDescription))
                        {
                            selectedGadget.Description = newDescription;
                        }

                        Console.Write("Enter new Review (press Enter to keep current review): ");
                        string newReview = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newReview))
                        {
                            selectedGadget.Review = newReview;
                        }

                        Console.WriteLine("Gadget updated successfully.");
                        break;

                    case 6:
                        Console.WriteLine("Are you sure you want to exit? (Yes/No)");
                        string userInput = Console.ReadLine();

                        if (userInput.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Exiting the program...");
                            return;
                        }
                        else if (userInput.Equals("No", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Exit canceled. Returning to the main menu.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                        }
                        break;
                }
            }
        }
    }
}