using System;
using System.Collections.Generic;
using System.Text;

namespace WzorceProj
{
    class Shop
    {

    }
    public interface IDbContext
    {
        void Save(string name);
    }
    interface ICart
    {
        void AddProduct(string name);
        void Checkout();
    }
    class LocalDB : IDbContext
    {
        public void Save(string name)
        {
            //zapis w cookies
        }
    }
    class SQLDB : IDbContext
    {
        public void Save(string name)
        {
            //zapis w bazie danych
        }
    }
    class ProxyChart : ICart
    {
        List<string> products;

        LocalDB cookie = new LocalDB();
        public void AddProduct(string name)
        {
            cookie.Save(name);
            products.Add(name);
        }

        public void Checkout()
        {
            Chart chart = new Chart();
            foreach (var item in products)
            {
                chart.AddProduct(item);
            }
            //czyszczenie bazy
        }
    }
    class Chart : ICart
    {
        List<string> products;
        SQLDB db = new SQLDB();
        public void AddProduct(string name)
        {
            db.Save(name);
        }

        public void Checkout()
        {

        }
    }
}
