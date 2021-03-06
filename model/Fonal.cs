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

        /// <summary>
        /// nem kívánt fonalak/színek visszatétele
        /// </summary>
        /// <param name="newFonal"></param>
        public void Remove(int newFonal)
        {
            if (newFonal < Piece)
                Piece = -newFonal;
            else
            {
                try
                {
                    throw new Exception("Jól meggondolta? Nem ajánlott visszatenni ennyi fonalat, mert akkor nem lesz kész a kívánt kendő.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Debug.WriteLine(e.Message);
                }
            }
        }
        /// <summary>
        /// karakterlánccá alakítás
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = "Ehhez a kendőhöz ilyen típusú fonal szükséges: " + type +
                "\nÖsszesen " + piece + " db fonal szükséges az elkészítéséhez. ";
            return output;
        }


        /// <summary>
        /// kendő osztály
        /// </summary>
        class Kendo //kendő osztály 
        {
            public string buyer; //vásárló
            public Fonal szivarvany; //szivárványszínű fonal
            public Fonal csillogo; //csillogós színű
            private object kisKendo; //kis kendő
            private Fonal nagyKendo; //nagy kendő

            /// <summary>
            /// Konstruktor 
            /// </summary>
            /// <param name="buyer">vásárló</param>
            /// <param name="szivarvany">szivrávány fonal</param>
            /// <param name="csillogo">csillogó fonal</param>
            public Kendo(string buyer, Fonal szivarvany, Fonal csillogo)
            {
                this.buyer = buyer;
                this.szivarvany = szivarvany;
                this.csillogo = csillogo;
            }

            public Kendo(object kisKendo, Fonal nagyKendo)
            {
                this.kisKendo = kisKendo;
                this.nagyKendo = nagyKendo;
            }

            /// <summary>
            /// vásárló tulajdonság
            /// </summary>
            public string Buyer
            { 
                get { return buyer; }
            }

            /// <summary>
            /// két féle fonal vásárlása
            /// </summary>
            /// <param name="kendo1"></param>
            /// <param name="kendo2"></param>
            /// <param name="piece"></param>
            public void Buying(Fonal kendo1, Fonal kendo2, int piece)
            {
                if (kendo1.Piece - piece > 0)
                {
                    kendo1.Piece -= piece;
                    kendo2.Piece = piece;
                }
                else
                    throw new Exception("Nincs készleten ennyi szivárnyszínű és csillogós fonal jelenleg.");
            }

            /// <summary>
            /// karakterlánccá alakítás
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                string output = "Vásárló neve: " + buyer;
                output += "\n Szivárványos kis kendőhöz fonalak: " + szivarvany.Type ;
                output += "\n Szivárványos nagy kendőhöz fonalak: " + szivarvany.Type ;
                output += "\n Csillogós kis kendőhöz fonalak: " + csillogo.Type ;
                output += "\n Csillogós nagy kendőhöz fonalak: " + csillogo.Type;
                output += "\n Vegyes színű kis kendőhöz fonalak" + csillogo.Type + szivarvany.Type;

                return output;
            }
        }
       
        
    }
   



}
