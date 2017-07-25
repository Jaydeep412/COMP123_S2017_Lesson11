using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name : Jaydeep Lakhwani
 * Date : 25th July, 2017
 * Description : This is the Deck class which inhertis from Card list
 * Version 0.4 - Added shuffle method
 */

namespace COMP123_S2017_Lesson11
{
    public class Deck: List<Card>
    {
        //PRIVATE INSTANCE VARIABLES (FIELDS)
        private Random _random;

        //Private PROPERTIES
        //private int Random
        //{
        //    get
        //    {

        //    }
        //    set
        //    {

        //    }
        //}
        //PUBLIC PROPERTIES

        //CONSTRUCTOR
        public Deck()
        {
            this._initialize();
        }
        //PRIVATE METHODS
        /// <summary>
        /// This is the private _initialize method that loads the deck with 52 cards.
        /// This method also initializes other class variables.
        /// </summary>

        private void _initialize()
        {
            //initialize the random object
          //  this._random = 

            //load the class with cards
            for (int suit=0; suit<= (int)Suit.Spades; suit++)
            {
                for (int face = 1; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face,(Suit)suit));
                }
            }
        }
        //PUBLIC METHODS

            /// <summary>
            /// This method overrides the built-in ToString method and the output.
            /// </summary>
            /// <returns></returns>
        public override string ToString()
        {
            string outString="";
            foreach(Card card in this)
            {
                outString += "The" + card.Face + "of" + card.Suit + "\n";
            }
            return outString;
        }

        //public void Shuffle()
        //{
        //    int firstCard;
        //    int secondCard;

        //    firstCard = this.Random.Next(0, 52);
        //    secondCard = this.Random.Next(0, 52);


        //}

    }
}