using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class PokerPlayer
    {
        public List<Card> Hands{get; set;}
        public PokerPlayer()

        {
            this.Hands = new List<Card>();
        }
        public void DrawCards(List<Card> CardList)
        {
            this.Hands = CardList;
        }

        public bool HasPair()
        {
            return this.Hands.Select(x => x.Rank).GroupBy(x => x).Count() == 2;  
        }
        public bool HasTwoPair()
        {
            return this.Hands.Select(x => x.Rank).Distinct().Count() == 3;
        }
        public bool HasThreeOfAKind()
        {
            return this.Hands.Select(x => x.Rank).GroupBy(x => x).Count() == 3;
        }
        public bool Straight()
        {
            return this.Hands.Select(x => x.Rank).GroupBy(x =>x).Count() == 0;
        }
        
    }
}