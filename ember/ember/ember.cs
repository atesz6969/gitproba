using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ember
{
    class Ember
    {
        string nev;
        int kor;
        string cim;
        int fizetes;
        public Ember(string _nev, int _kor, string _cim, int _fizetes)
        {
            nev = _nev;
            kor = _kor;
            cim = _cim;
            fizetes = _fizetes;
        }

        public string nev { get { return nev; } }
        public int kor { get { return kor; } }
        public string cim { get { return cim; } }
        public int fizetes { get { return fizetes; } }

    }

    
    
    
}
