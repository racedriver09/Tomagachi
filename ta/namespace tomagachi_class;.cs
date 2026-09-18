using System.Diagnostics;

namespace tomagachi_class;


public class tomagachi
{

  private int hunger = 0;
  private int bordem = 0;
  private List<string> Words = new List<string>();
  private bool is_alive = true;

  public string name;

  private List<int> random_number = new List<int>();

  Program prog = new Program();


  public int option = 1;


  static Random ran = new Random();






  public void feed()
  {
    random_number.Add(1);
    random_number.Add(2);
    random_number.Add(3);
    random_number.Add(4);
    random_number.Add(5);


    hunger -= ran.Next(random_number.Count);

    if (hunger <= 0)
    {
      hunger = 0;
    }
  }

  public void hi()
  {
    if (Words.Count != 0)
    {
      int Random_Word = ran.Next(Words.Count);
      bordem -= 1;

      Console.WriteLine((String)Words[Random_Word]);

    }
    else
    {
      Console.WriteLine("Your toma dosent know any words");
    }



  }

  public void teach()
  {
    Words.Add("\n" + Console.ReadLine());

  }

  public void tick()
  {
    hunger += 1;
    bordem += 1;

    if (hunger == 10 || bordem == 10)
    {
      is_alive = false;
    }



  }

  public void print_stat()
  {
    Console.WriteLine("\n" + hunger);
    Console.WriteLine("\n" + bordem);
  }

  public bool Get_Alive()
  {
    return is_alive && option != 6;

  }


  public void Reduce_Bordome()
  {

    random_number.Add(1);
    random_number.Add(2);
    random_number.Add(3);
    random_number.Add(4);
    random_number.Add(5);


    bordem -= ran.Next(random_number.Count);

    if (bordem <= 0)
    {
      bordem = 0;
    }
  }

  public void Draw_tamagachi()
  {


  }

  public void Do_Nothing()
  {

  }

  

}

