using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author : Joanne Jung
 * Student Number : 300432364
 * Description : Card class for Lab5
 */
namespace COMP123_Lab3
{
    public class Card
    {
        /**
         * <summary>
         * This class creates an object that represents a playing card
         * </summary>
         * 
         * @class Card
         */
        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public int Face { get; set; }
        public string Suit { get; set; }
        /**
         * <summary>
         * This constructor takes two parameters: face and suit to instantiate a Card object
         * </summary>
         * 
         * @constructor Card
         * @param {string} face
         * @param {string} suit
         */
        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
