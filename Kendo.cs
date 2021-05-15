using System;
using gyak_03_01_01_task_NagyAnnaViola.model;

namespace gyak_03_01_01_task_NagyAnnaViola
{
    internal class Kendo
    {
        private string v;
        private Fonal kisKendo;
        private Fonal nagyKendo;

        public Kendo(string v, Fonal kisKendo, Fonal nagyKendo)
        {
            this.v = v;
            this.kisKendo = kisKendo;
            this.nagyKendo = nagyKendo;
        }

        internal void Buying(Fonal nagyKendo, Fonal kisKendo, int v)
        {
            throw new NotImplementedException();
        }
    }
}