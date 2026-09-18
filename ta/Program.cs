using tomagachi_class;
using setup_Controle;
using System;
using System.Net;
using System.Runtime.InteropServices;
//tomagachi toma = new tomagachi();

Setup Keybinds = new Setup();




List<tomagachi> tomas = new List<tomagachi>();

 int option = 1;

ConsoleKeyInfo key;

Console.ForegroundColor = ConsoleColor.Red;

string Color = "\u001b[35m";

string Normal_color = "\u001b[32m";

bool is_Selected = false;

int index;

(int left, int top) = Console.GetCursorPosition();

List<string> tomas_names = new List<string>();









int chosen_toma;





//toma.name = Console.ReadLine();

void Console_ReadLine()
{
        Console.WriteLine($"  {(option == 2 ? Color : "")}{(tomas[index]).name}\u001b[32m");
}



void buy()
{
    index = tomas.Count;
    
    if (tomas.Count == 0)
    {
        while (!is_Selected)
        {

            Console.SetCursorPosition(left, top);

            Console.WriteLine($"  {(option == 1 ? Color : "")}make new\u001b[32m");
            Console.WriteLine($"  {(option == 2 ? Color : "")}stop\u001b[32m");

            key = Console.ReadKey(true);

            switch (key.Key)
            {

                case ConsoleKey.DownArrow:

                    option = (option == 2 ? 1 : option + 1);
                    break;

                case ConsoleKey.UpArrow:
                    option = (option == 1 ? 2 : option - 1);
                    break;

                case ConsoleKey.Enter:
                    is_Selected = true;
                    break;

            }


        }
        if (option == 1)
        {

            tomagachi tomas_1 = new tomagachi();

            tomas.Add(tomas_1);

            chosen_toma = 0;
            main();

        }
        else if (option == 2)
        {


        }
    }

    else
    {

        while (!is_Selected)
        {

            Console.SetCursorPosition(left, top);

            Console.WriteLine($"  {(option == 1 ? Color : "")}make new\u001b[32m");
         
             Console.WriteLine($"  {(option == 2 ? Color : "")}{(tomas[0]).name}\u001b[32m");
            
            //Console.WriteLine($"  {(option == 2 ? Color : "")}{(tomas[0]).name}\u001b[32m");
            Console.WriteLine($"  {(option == 3 ? Color : "")}stop\u001b[32m");

            key = Console.ReadKey(true);

            switch (key.Key)
            {

                case ConsoleKey.DownArrow:

                    option = (option == 3 ? 1 : option + 1);
                    break;

                case ConsoleKey.UpArrow:
                    option = (option == 1 ? 3 : option - 1);
                    break;

                case ConsoleKey.Enter:
                    is_Selected = true;
                    break;

            }
        }

        if (option == 1)
        {

            tomagachi tomas_2 = new tomagachi();

            tomas.Add(tomas_2);

            chosen_toma = 1;
            main();

        }
        else if (option == 2)
        {
            chosen_toma = 0;
            main();
        }
        else if (option == 3)
        {


        }
    }  

}




  
   


void main()
{
    if (tomas[chosen_toma].name == null)
    {
        Console.WriteLine(Color + "name your toma ");
        tomas[chosen_toma].name = Console.ReadLine();
        tomas_names.Add(tomas[chosen_toma].name);
    }
   

    while (tomas[chosen_toma].Get_Alive())
    {
        
        Console.Clear();
        tomas[chosen_toma].tick();









        while (!is_Selected)
        {

            Console.SetCursorPosition(left, top);   // get's cursure positioin

            Console.WriteLine($"  {(option == 1 ? Color : "")}feed\u001b[32m");
            Console.WriteLine($"  {(option == 2 ? Color : "")}inter\u001b[32m");
            Console.WriteLine($"  {(option == 3 ? Color : "")}hi\u001b[32m");
            Console.WriteLine($"  {(option == 4 ? Color : "")}teach\u001b[32m");
            Console.WriteLine($"  {(option == 5 ? Color : "")}loiter\u001b[32m");
            Console.WriteLine($"  {(option == 6 ? Color : "")}back to toma store\u001b[32m");

            key = Console.ReadKey(true);

            //lets me bind specifick keys like UpArrow by creatinh a key in a switch, to bind indevidual keys by typing case => "key" then break when what it's supost to do is done.  

            switch (key.Key)
            {

                case ConsoleKey.DownArrow:

                    option = (option == 6 ? 1 : option + 1);
                    break;

                case ConsoleKey.UpArrow:
                    option = (option == 1 ? 6 : option - 1);
                    break;

                case ConsoleKey.Enter:
                    is_Selected = true;
                    break;

            }

           
        }


        Console.Clear();

        if (option == 1) tomas[chosen_toma].feed();
        else if (option == 2) tomas[chosen_toma].Reduce_Bordome();
        else if (option == 3) tomas[chosen_toma].hi();
        else if (option == 4) tomas[chosen_toma].teach();
        else if (option == 5) tomas[chosen_toma].Do_Nothing();



        Console.WriteLine("\nyour tomas name " + tomas[chosen_toma].name);

        tomas[chosen_toma].print_stat();

        Console.ReadKey();

        tomas[chosen_toma].option = option;

        // in Get alive it checks both if it's dead and what option is 
        //the resoning for this is that it need mulltibal ways to get outside/end the mamin loop.

        is_Selected = false;




    }

     //if you have ended the loop one of two things have happend you went to the store or te tomas dead, could maeby make a more flexabel loop honestly but it does what it need to.
    if (option != 6)
    {
        Console.WriteLine(tomas[chosen_toma].name + " is dead:( :( ...........................");

        Console.ReadKey();
    }
    else if (option == 6)
    {
        option = 1;

        tomas[chosen_toma].option = 1;



        Console.Clear();

        buy();

    }

       
    

}

void hnadling_agent()
{
    buy();
}

hnadling_agent();


Program prog;





//Console.ReadKey();


