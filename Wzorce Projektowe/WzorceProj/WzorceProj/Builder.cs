using System;
using System.Collections.Generic;
using System.Text;

namespace WzorceProj
{
    /*Builder rozni sie od Factory o tyle ze mamy tutaj mozliwosc dzialania na obiekcie, gdzie
     Factory daje nam same obiekty*/ 
    class Builder
    {
        private string _query;
        public Builder Select(string query)
        {
            this._query = query;
            /*poprzez zwracanie this implementuje sie fluent interface, pozwala na
             lancuchowe wywolanie metod w obiekcie*/
            return this;
        }
        public Builder From(string query)
        {
            this._query += " from: " + query;
            return this;
        }
        public string GetQuery
        {
            get { return _query; }
        }

    }
}
