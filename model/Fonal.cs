using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            try
            {
                if (piece == 1) //egy darab fonal
                    throw new Exception("Egy fonalból nem lehet megfelelő méretű horgolt kendőt, illetve amigurumi fiugrát készíteni, " +
                        "kérem tegyen még a kosárába fonalat.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Debug.WriteLine(e.Message);
            }
            this.type = type;
            this.piece = piece;
        }

        
    }



}
