using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name : Jaydeep Lakhwani
 * Date : 25th July, 2017
 * Description : This is the Deck class which inhertis from Card list
 * Version 0.3 - Fixed bug in ToString method
 */

namespace COMP123_S2017_Lesson11
{
    public class Deck: List<Card>
    {
        //PRIVATE INSTANCE VARIABLES (FIELDS)

        //PUBLIC PROPERTIES

        //CONSTRUCTOR
        public Deck()
        {
            this._initialize();
        }
        //PRIVATE METHODS

        private void _initialize()
        {
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
    }
}