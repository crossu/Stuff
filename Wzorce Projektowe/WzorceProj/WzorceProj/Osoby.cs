using System;
using System.Collections.Generic;
using System.Text;

namespace WzorceProj
{
    class Osoby
    {
        private List<Osoby> _pracownicy;
        private string _name;
        public Osoby(string name)
        {
            this._name = name;
        }
        public void AddPracownik(Osoby pracownik)
        {
            _pracownicy.Add(pracownik);
        }

        public string Show()
        {
            foreach (Osoby pracownik in _pracownicy)
            {
                pracownik.Show();
            }
            return this._name;
        }
    }
}
