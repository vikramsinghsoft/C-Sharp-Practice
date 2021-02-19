using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Customer
    {
        int _CustId;
        bool _Status;
        string _Cname, _State;
        double _Balance;
        Cities _City;

        public Customer(int CustId, bool Status, string Cname, double Balance, Cities City,string State)
        {
            _CustId = CustId;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
            _City = City;
            _State = State;
           
        }

        public  int CustId { get { return _CustId; } }
        public  bool Status { get { return _Status; } set {_Status = value; } }
        public  string Cname { get { return _Cname; } set {if(_Status==true) _Cname = value; } }

        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    if (value >=0)     //for minimum balance 
                        _Balance = value;
                }
            }
        }

        public  Cities City 
        {
            get { return _City; }
            set
            {
                if (_Status == true)
                    _City = value;
            } 
        }

        public  string State 
        { 
            get { return _State; } 
            protected set { if (_Status == true) _State = value; } 
        }

        public string Country  // Auto-Implemented or Aotumatic property(3.0)
        {
            get;

        } = "India";  // Auto-Property Initializer(6.0)
    }
}
