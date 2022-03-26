using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab2New.Controllers
{
    public class CardController : ApiController
    {


        [Route("api/cardType/{cardFromUser}")]

        public IEnumerable<Card> getCard(string cardFromUser)
        {
            string[] cards = new string[12];
            List<Card> cardList = new List<Card>();

            if (cardFromUser.Equals("paus"))
            {
                for (int i = 1; i <= 13; i++)
                {
                    
                    Card c = new Card();
                    c.imageLink = "https://deckofcards2.blob.core.windows.net/cardstorage/" + "0-" + (i) + ".PNG";

                    cardList.Add(c);                 

                    //return url;
                    // create a card
                    // set imagelink
                    // add car to list 
                }

            };
                       
            return cardList;                     
                       
        }

    }
}