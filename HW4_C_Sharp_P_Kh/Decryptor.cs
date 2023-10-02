using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_C_Sharp_P_Kh
{
    internal class Decryptor
    {
        private string _text;
        static private int _minNumUppercase; 
        static private int _maxNumUppercase; 
        static private int _minNumLowercase; 
        static private int _maxNumLowercase; 
        static private int _rightShift; 

        static Decryptor()
        {
            _minNumUppercase = 65;
            _maxNumUppercase = 90;
            _minNumLowercase = 97;
            _maxNumLowercase = 122;
            _rightShift = 3;
        }

        public void AddText(string text)
        {
            this._text = text;
        }
        public void Decipher()
        {
            if (_text.Length > 0)
            {
                StringBuilder sb = new StringBuilder(_text);
                for (int i = 0; i < _text.Length; i++)
                {
                    int tempNumSymb = Convert.ToInt32(_text[i]);
                    if (tempNumSymb >= _minNumUppercase && tempNumSymb <= _maxNumUppercase)
                    {
                        if ((tempNumSymb - _rightShift) >= _minNumUppercase)
                        {
                            char tempSymb = Convert.ToChar(tempNumSymb - _rightShift);
                            sb[i] = tempSymb;

                        }
                        else
                        {
                            char tempSymb = Convert.ToChar((_maxNumUppercase + (_minNumUppercase - (tempNumSymb - _rightShift))));
                            sb[i] = tempSymb;
                        }
                    }
                    else if (tempNumSymb >= _minNumLowercase && tempNumSymb <= _maxNumLowercase)
                    {
                        if ((tempNumSymb - _rightShift) >= _minNumLowercase)
                        {
                            char tempSymb = Convert.ToChar(tempNumSymb - _rightShift);
                            sb[i] = tempSymb;

                        }
                        else
                        {
                            char tempSymb = Convert.ToChar((_maxNumLowercase + (_minNumLowercase - (tempNumSymb - _rightShift))));
                            sb[i] = tempSymb;
                        }
                    }
                }
                _text = Convert.ToString(sb);
            }

        }

        public string GetText()
        {
            return _text;
        }
    }
}
