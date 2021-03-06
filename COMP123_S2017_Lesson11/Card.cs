﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name : Jaydeep Lakhwani
 * Date : 25th July, 2017
 * Description : This is the Card class to be used in the card
 * shuffling and dealing simulation
 * Version 0.1 - Created the Card Class.
 */


namespace COMP123_S2017_Lesson11
{
    public class Card
    {
        //PRIVATE INSTANCE VARIABLES (FIELDS)
        private Face _face;
        private Suit _suit;

        //PUBLIC PROPERTIES
        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }

        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }

        //CONSTRUCTOR
        /// <summary>
        /// This is the main constructor for Card class;
        /// It takes two parameters - face(Face) - suit(Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        //PRIVATE METHODS

        //PUBLIC METHODS
    }
}