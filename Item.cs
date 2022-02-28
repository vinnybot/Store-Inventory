using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Item
    {
        private string _name;
        private string _upc;
        private double _storePrice;
        private double _costPerCase;
        private int _unitsPerCase;
        private string _distributor;
        public Item(string name, string upc, double storePrice, double costPerCase, int unitsPerCase, string distributor)
        {
            _name = name;
            _upc = upc;
            _storePrice = storePrice;
            _costPerCase = costPerCase;
            _unitsPerCase = unitsPerCase;
            _distributor = distributor;
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String upc
        {
            get { return _upc; }
            set { _upc = value; }
        }
        public double storePrice
        {
            get { return _storePrice; }
            set { _storePrice = value; }
        }
        public double costPerCase
        {
            get { return _costPerCase; }
            set { _costPerCase = value; }
        }
        public int unitsPerCase
        {
            get { return _unitsPerCase; }
            set { _unitsPerCase = value; }
        }
        public String distributor
        {
            get { return _distributor; }
            set { _distributor = value; }
        }
    }
}

