using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asmxApiOrnek1
{
    public class Insan
    {
        int _id;
        string _adSoyad;
        string _tel;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string AdSoyad
        {
            get
            {
                return _adSoyad;
            }

            set
            {
                _adSoyad = value;
            }
        }

        public string Tel
        {
            get
            {
                return _tel;
            }

            set
            {
                _tel = value;
            }
        }
    }
}