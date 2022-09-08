

    Console.WriteLine("Hello, choose your name Luck or Nexus");

    string name = Console.ReadLine();
    // name = name.ToLower();

    Console.WriteLine($"Hello {name}");


    if (name.ToLower() == "luck")
    {

        Console.WriteLine("Luck your luck has ended!");
        
        

    }
    else if (name.ToLower() == "nexus")
    {
        Console.WriteLine("A wise choice and personally my favourite one");

        Console.WriteLine("save yourself or save drowning kid");


        string save = Console.ReadLine();

        if (save == "save yourself")
        {
            Console.WriteLine("You got stabbed from behind");
        }
        else if (save == "save drowning kid")
        {
            Console.WriteLine("You both survived");
            Console.WriteLine("Congrats you made it to the end");
        }








    }

    else
    {

    }
    Console.ReadLine();
    

