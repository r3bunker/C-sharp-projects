using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            
            for (int i = 0; i < 13; i++)
            {
                for (int s = 0; s < 4; s++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)s;
                    Cards.Add(card);
                }
            }
            
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            
            for (int i = 0; i < times; i++)
            {
                
                List<Card> tempList = new List<Card>();
                Random random = new Random();

                // Shuffles Deck
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;
            }
            

        }


    }
}
