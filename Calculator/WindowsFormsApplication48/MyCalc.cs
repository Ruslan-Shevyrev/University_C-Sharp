using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication48
{
    class MyCalc
    {
        public int razm(int Schetchik, int Sistema)
        {
            int razm = 0;
            while (Schetchik != 0)
            {
                Schetchik /= Sistema;
                razm++;
            }
            return razm;
        }

        public string[] obr(int chislo, int sistema, string[] obratn)
        {
           int schetchik = chislo;
            int ind = 0;
            while (schetchik != 0)
            {
                chislo = schetchik % sistema;
                schetchik /= sistema;
                switch (chislo)
                {
                    case 10:
                        obratn[ind] = "A";
                        break;
                    case 11:
                        obratn[ind] = "B";
                        break;
                    case 12:
                        obratn[ind] = "C";
                        break;
                    case 13:
                        obratn[ind] = "D";
                        break;
                    case 14:
                        obratn[ind] = "E";
                        break;
                    case 15:
                        obratn[ind] = "F";
                        break;
                    default:
                        obratn[ind] = Convert.ToString(chislo);
                        break;
                }
                ind++;
            }
            return obratn;   
        }

        public void start(string znach, int sistema, out int chislov10)
        {
            double u = 0;
        int i = 0;
            foreach (char c in znach)
            {
                switch (c)
                {
                    case '1':
                        u += 1 * Math.Pow(sistema, i);
                        break;
                    case '2':
                        u += 2 * Math.Pow(sistema, i);
                        break;
                    case '3':
                        u += 3 * Math.Pow(sistema, i);
                        break;
                    case '4':
                        u += 4 * Math.Pow(sistema, i);
                        break;
                    case '5':
                        u += 5 * Math.Pow(sistema, i);
                        break;
                    case '6':
                        u += 6 * Math.Pow(sistema, i);
                        break;
                    case '7':
                        u += 7 * Math.Pow(sistema, i);
                        break;
                    case '8':
                        u += 8 * Math.Pow(sistema, i);
                        break;
                    case '9':
                        u += 9 * Math.Pow(sistema, i);
                        break;
                    case '0':
                        u += 0 * Math.Pow(sistema, i);
                        break;
                    case 'A':
                    case 'a':
                        u += 10 * Math.Pow(sistema, i);
                        break;
                    case 'B':
                    case 'b':
                        u += 11 * Math.Pow(sistema, i);
                        break;
                    case 'C':
                    case 'c':
                        u += 12 * Math.Pow(sistema, i);
                        break;
                    case 'D':
                    case 'd':
                        u += 13 * Math.Pow(sistema, i);
                        break;
                    case 'E':
                    case 'e':
                        u += 14 * Math.Pow(sistema, i);
                        break;
                    case 'F':
                    case 'f':
                        u += 15 * Math.Pow(sistema, i);
                        break;
                }
                i++;
            }
            chislov10 = (int)u;
        }

        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public bool flag(string znach, int sistema)
        {
            bool flag = true;
            int i = 0;
            foreach (char c in znach)
            {
                switch (c)
                {
                    case '1':
                        i = 1;
                        break;
                    case '2':
                        i = 2;
                        break;
                    case '3':
                        i = 3;
                        break;
                    case '4':
                       i = 4;
                        break;
                    case '5':
                        i = 5;
                        break;
                    case '6':
                        i = 6;
                        break;
                    case '7':
                        i = 7;
                        break;
                    case '8':
                        i = 8;
                        break;
                    case '9':
                       i = 9;
                        break;
                    case '0':
                        i = 0;
                        break;
                    case 'A':
                    case 'a':
                       i = 10;
                        break;
                    case 'B':
                    case 'b':
                        i = 11;
                        break;
                    case 'C':
                    case 'c':
                       i = 12;
                        break;
                    case 'D':
                    case 'd':
                        i = 13;
                        break;
                    case 'E':
                    case 'e':
                        i = 14;
                        break;
                    case 'F':
                    case 'f':
                       i = 15;
                        break;
                    default:
                        flag = false;
                        break;
                }
                if (i >= sistema)
                {
                    flag = false;
                    break;
                }
            }
    return flag;
        
        
        }

    }
}
