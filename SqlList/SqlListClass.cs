using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlList
{
    public  class SqlListClass
    {
        const int MaxSize = 100;
        public string[] data;
        public int length;

        public SqlListClass()
        {
            data = new string[MaxSize];
            length = 0;
        }

        public void CreateList(string[] split)
        {
            for (int i = 0; i < split.Length; i++)
            {
                data[i] = split[i];
                length = i + 1;
            }
        }

        public string DisplayList()
        {
            if (length > 0)
            {
                string mystr = string.Empty;
                for (int i = 0; i < length; i++)
                {
                    mystr += data[i] + " ";
                }
                return mystr;
            }
            else
            {
                return "空串";
            }
        }

        public int ListLength()
        {
            return length;
        }

        public bool GetElem(int i, ref string e)
        {
            if (i < 1 || i > length)
            {
                return false;
            }
            e = data[i - 1];
            return true;
        }

        public int LocateElem(string e)
        {
            int i = 0;
            while (i < length && !data[i].Equals(e))
            {
                i++;
            }
            if (i >= length)
            {
                return 0;
            }
            else
            {
                return i + 1;
            }
        }

        public bool ListInsert(int i, string e)
        {
            if (i < 1 || i > length + 1)
            {
                return false;
            }
            for (int j = length; j >= i; j--)
            {
                data[j] = data[j - 1];
            }
            data[i - 1] = e;
            length++;
            return true;
        }

        public bool ListDelete(int i, ref string e)
        {
            if (i < 1 || i > length)
            {
                return false;
            }
            for (int j = i - 1; j < length - 1; j++)
            {
                data[j] = data[j + 1];
            }
            length--;
            return true;
        }

        public bool ListRemoveElem(string e)
        {
            int i = 0;
            while (i < length && !data[i].Equals(e))
            {
                i++;
            }
            if (i > length - 1)
            {
                return false;
            }
            else
            {
                for (int j = i; j < length; j++)
                {
                    data[j] = data[j + 1];
                }
                length--;
                return true;
            }  
        }

        public void Reverse(ref SqlListClass L)
        {
            string tmp = string.Empty;
            for (int i = 0; i < L.length / 2; i++)
            {
                tmp = L.data[i];
                L.data[i] = L.data[L.length - i - 1];
                L.data[L.length - i - 1] = tmp;
            }
        }

        public void Merge2(SqlListClass L1, SqlListClass L2, ref SqlListClass L3)
        {
            int i = 0,  j = 0, k = 0;
            while (i < L1.length && j < L2.length)
            {
                if (Convert.ToInt32(L1.data[i]) <= Convert.ToInt32(L2.data[j]))
                {
                    L3.data[k] = L1.data[i];
                    i++;
                    k++;
                }
                else
                {
                    L3.data[k] = L2.data[j];
                    j++;
                    k++;
                }
            }
            while (i < L1.length)
            {
                L3.data[k] = L1.data[i];
                i++;
                k++;
            }
            while (j < L2.length)
            {
                L3.data[k] = L2.data[j];
                j++;
                k++;
            }
            L3.length = k;
        }

        public void Merge3(SqlListClass L1,SqlListClass L2,SqlListClass L3,ref SqlListClass L4)
        {
            int i = 0, j = 0, k = 0, l = 0;
            while (i < L1.length && j < L2.length && k < L3.length)
            {
                if (Convert.ToInt32(L1.data[i]) <= Convert.ToInt32(L2.data[j]) && Convert.ToInt32(L1.data[i]) <= Convert.ToInt32(L3.data[k]))
                {
                    L4.data[l] = L1.data[i];
                    i++;
                    l++;
                }
                else if(Convert.ToInt32(L2.data[j]) <= Convert.ToInt32(L1.data[i]) && Convert.ToInt32(L2.data[j]) <= Convert.ToInt32(L3.data[k]))
                {
                    L4.data[l] = L2.data[j];
                    j++;
                    l++;
                }
                else if(Convert.ToInt32(L3.data[k]) <= Convert.ToInt32(L1.data[i]) && Convert.ToInt32(L3.data[k]) <= Convert.ToInt32(L2.data[j]))
                {
                    L4.data[l] = L3.data[k]; 
                    k++; 
                    l++;
                }
                else if(Convert.ToInt32(L1.data[i]) <= Convert.ToInt32(L2.data[j]) && Convert.ToInt32(L1.data[i]) >= Convert.ToInt32(L3.data[k]))
                {
                    L4.data[l] = L3.data[k];
                    k++;
                    l++;
                }
                else if(Convert.ToInt32(L2.data[j]) <= Convert.ToInt32(L1.data[i]) && Convert.ToInt32(L2.data[j]) >= Convert.ToInt32(L3.data[k]))
                {
                    L4.data[l] = L3.data[k];
                    k++;
                    l++;
                }
                else if(Convert.ToInt32(L3.data[k]) <= Convert.ToInt32(L1.data[i]) && Convert.ToInt32(L3.data[k]) >= Convert.ToInt32(L2.data[j]))
                {
                    L4.data[l] = L2.data[j];
                    j++;
                    l++;
                }
                else if(Convert.ToInt32(L1.data[i]) >= Convert.ToInt32(L2.data[j]) && Convert.ToInt32(L1.data[i]) <= Convert.ToInt32(L3.data[k]))
                {
                    L4.data[l] = L2.data[j];
                    j++;
                    l++;
                }
                else if(Convert.ToInt32(L2.data[j]) >= Convert.ToInt32(L1.data[i]) && Convert.ToInt32(L2.data[j]) <= Convert.ToInt32(L3.data[k]))
                {
                    L4.data[l] = L1.data[i];
                    i++;
                    l++;
                }
                else if(Convert.ToInt32(L3.data[k]) >= Convert.ToInt32(L1.data[i]) && Convert.ToInt32(L3.data[k]) <= Convert.ToInt32(L2.data[j]))
                {
                    L4.data[l] = L1.data[i];
                    i++;
                    l++;
                }
            }
            while (i < L1.length && j < L2.length)
            {
                if (Convert.ToInt32(L1.data[i]) < Convert.ToInt32(L2.data[j]))
                {
                    L4.data[l] = L1.data[i];
                    i++;
                    l++;
                }
                else
                {
                    L4.data[l] = L2.data[j];
                    j++;
                    l++;
                }
            }
            while(i < L1.length && k < L3.length)
            {
                if (Convert.ToInt32(L1.data[i]) < Convert.ToInt32(L3.data[k]))
                {
                    L4.data[l] = L1.data[i];
                    i++;
                    l++;
                }
                else
                {
                    L4.data[l] = L3.data[k];
                    k++;
                    l++;
                }
            }
            while(j < L2.length && k < L3.length)
            {
                if (Convert.ToInt32(L2.data[j]) < Convert.ToInt32(L3.data[k]))
                {
                    L4.data[l] = L2.data[j];
                    j++; 
                    l++;
                }
                else
                {
                    L4.data[l] = L3.data[k]; 
                    k++;
                    l++;
                }
            }
            while(i < L1.length)
            {
                L4.data[l] = L1.data[i];
                i++;
                l++;
            }
            while(j < L2.length)
            {
                L4.data[l] = L2.data[j];
                j++;
                l++;
            }
            while(k < L3.length)
            {
                L4.data[l] = L3.data[k];
                k++;
                l++;
            }
            L4.length = l;
        }

        public void OddAndEven(SqlListClass L1, ref SqlListClass L2, ref SqlListClass L3)
        {
             int i = 0, j = 0, k = 0;
            for (i = 0; i < L1.length; i++)
              {
                if (Convert.ToInt32(L1.data[i]) % 2 != 0)
                {
                    L2.data[j] = L1.data[i];
                    j++;
                }
                else
                {
                    L3.data[k] = L1.data[i];
                    k++;
                }
            }
             L2.length = j;
            L3.length = k;
        }
    }
}
