using System;
using System.Linq;

namespace moneti_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int stotinki = (int)(100 * decimal.Parse(Console.ReadLine()));
            Money[] money = new Money[]
                {
                    new Money("petolevka",500,false),
                    new Money("dvulevka",200),
                    new Money("ednolevka",100),
                    new Money("petdeset stotinki",50),
                    new Money("dvadeset stotinki",20),
                    new Money("deset stotinki",10),
                    new Money("pet stotinki",5),
                    new Money("dve stotinki", 2),
                    new Money("edna stotinka", 1)
                };

            foreach (Money coin in money)
            {
                coin.Count = stotinki / coin.StotinkovaStoinost;
                stotinki -= coin.StotinkovaStoinost;
            }

            foreach (Money coin in money.Where(x=>x.Count>0))
            {
                Console.WriteLine($"{coin.Name} -> {coin.Count} br.");
            }

           
            }
        }
    }

    class Money
    {

  

    
    public Money(string name, int stotinkovaStoinost,bool isCoin=true)
    {
        Name = name;
        StotinkovaStoinost = stotinkovaStoinost;
        Count = 0;
        IsCoin = isCoin;
    }

    public string Name { get; set; }
        public int StotinkovaStoinost { get; set; }
        public int Count { get; set; }
    public bool IsCoin { get; set; }

    public override string ToString()
    {
        if (IsCoin)
        {
            return $"{Name} -> {Count} br.";
        }
        else
        {
            return $"Banknota {Name} -> {Count} br.";
        }
    }
}

