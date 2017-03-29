using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharptry
{
    
    class Canon144Z
    {
        private int pages;
        public Canon144Z() { pages = 500; }
        public void Print(int printpages)
        {
            Console.WriteLine("Try to print {0} pages",printpages);
            pages -= printpages;
            Console.WriteLine("Printed {0} pages",printpages);
        }
        public void ErrorPrint(int addpages)
        {
            pages += addpages;
            Console.WriteLine("Error in printing,reprint {0} pages",addpages);
        }
        public void PagesRest()
        {
            Console.WriteLine("{0} pages rest.", pages);
        }
        public void SetMemento(Printeer memento)
        {
            pages = memento.ControlPages();
        }
        public Printeer GetPrinter()
        {
            return new Printeer(pages);
        }
    }

    internal class Printeer
    {
        private int pages;
        public Printeer(int _pages)
        {
            pages = _pages;
        }
        public int ControlPages()
        {
            return pages;
        }
    }

    class Features
    {
        private Printeer memento;
        public void Save(Canon144Z canon)
        {
            if (canon == null)
                throw new ArgumentNullException("No printer");
            memento = canon.GetPrinter();
            Console.WriteLine("Save state");
        }
        public void LoadState(Canon144Z canon)
        {
            if (canon == null)
                throw new ArgumentNullException("No printer");
            if (memento == null)
                throw new ArgumentNullException("Memento is null");
            canon.SetMemento(memento);
            Console.WriteLine("Load");
        }
    }
}
