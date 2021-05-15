using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_03_01_01_task_NagyAnnaViola.model
{
    class Fonal
    {
        private string type; //fonal típusa
        private int piece; //hány darab fonal adott fonal típusból

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="type">fonal típusa</param>
        /// <param name="piece">darabszám</param>
        public Fonal(string type, int piece)
        {
            this.type = type;
            this.piece = piece;
        }
    }



}
