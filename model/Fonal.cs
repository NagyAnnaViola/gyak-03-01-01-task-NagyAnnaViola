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
                    throw new Exception("Egy fonalból nem lehet megfelelő méretű horgolt kendőt készíteni, " +
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

        /// <summary>
        /// Fonal típusának tulajdonsága
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// kért fonal mennyiség számítása
        /// </summary>
        public int Piece
        {
            get { return piece; }
            set 
            {
                if (value > 0)
                    piece += value;
                else try
                    {
                        throw new Exception("Minusz számú fonalat nem lehet kérni. ");
                    }
                 catch (Exception ex)
                    {
                        Debug.WriteLine("Minusz érték nem szerepelhet itt.");
                        Console.WriteLine(ex.Message);
                    }
            }
        }

        /// <summary>
        /// további fonalak/színek hozzáadása
        /// </summary>
        /// <param name="newFonal"></param>
        public void Add(int newFonal)
        {
            if (piece + newFonal <= 50)
                piece += newFonal;
            else
            {
                try
                {
                    throw new Exception("Ennél több szín/fonal nem szükséges a kívánt horgolt kendő elkészítéséhez");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Debug.WriteLine(e.Message);
                }
            }
        }

        
    }



}
