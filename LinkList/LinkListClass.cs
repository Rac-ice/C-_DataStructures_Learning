using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class LinkList
    {
        public string data;
        public LinkList next;
    }

    public class LinkListClass
    {
        LinkList head = new LinkList();
       
        public void CreateListF(string[] split)
        {
            LinkList s;
            int i;
            head.next = null;
            for (i = 0; i < split.Length; i++)
            {
                s = new LinkList();
                s.data = split[i];
                s.next = head.next;
                head.next = s;
            }
            head.data = (i).ToString();
        }

        public void CreateListR(string[] split)
        {
            LinkList s, r;
            int i;
            r = head;
            for (i = 0; i < split.Length; i++)
            {
                s = new LinkList();
                s.data = split[i];
                r.next = s;
                r = s;
            }
            r.next = null;
            head.data = i.ToString();
        }


        public string DisplayList()
        {
            string str = string.Empty;
            LinkList p;
            p = head.next;
            if (p == null)
            {
                str = "空串";
            }
            while (p!=null)
            {
                str += p.data + " ";
                p = p.next;
            }
            return str;
        }

        public int ListLength()
        {
            return Convert.ToInt32(head.data);
        }

        public bool GetElem(int i,ref string e)
        {
            int j = 0;
            if (i < 1)
            {
                return false;
            }
            LinkList p = head;
            while (j < i && p != null)
            {
                j++;
                p = p.next;
            }
            if (p == null)
            {
                return false;
            }
            else
            {
                e = p.data;
                return true;
            }
        }

        public int LocateElem(string e)
        {
            int i = 1;
            LinkList p = head.next;
            while (p != null && p.data != e)
            {
                p = p.next;
                i++;
            }
            if (p == null)
            {
                return 0;
            }
            else
            {
                return i;
            }
        }

        public bool ListInsert(int i,string e)
        {
            int j = 0;
            LinkList s, p;
            if (i < 1)
            {
                return false;
            }
            p = head;
            while (j < i -1 && p != null)
            {
                j++;
                p = p.next;
            }
            if (p == null)
            {
                return false;
            }
            else
            {
                s = new LinkList();
                s.data = e;
                s.next = p.next;
                p.next = s;
                head.data = (Convert.ToInt32(head.data)+1).ToString();
                return true;
            }
        }

        public bool ListDelete(int i,ref string e)
        {
            int j = 0;
            LinkList q, p;
            if (i < 1)
            {
                return false;
            }
            p = head;
            while (j < i - 1 && p != null)
            {
                j++;
                p = p.next;
            }
            if (p == null)
            {
                return false;
            }
            else
            {
                q = p.next;
                if (q == null)
                {
                    return false;
                }
                else
                {
                    e = q.data;
                    p.next = q.next;
                    q = null;
                    head.data = (Convert.ToInt32(head.data) - 1).ToString();
                    return true;
                }
            }
        }

        public bool ListRemoveElem(string e)
        {
            LinkList p = head.next;
            LinkList tmp = head;
            while (p != null && p.data != e)
            {
                tmp = tmp.next;
                p = p.next;
            }
            if (p == null)
            {
                return false;
            }
            else
            {
                if (p.data == e)
                {
                    tmp.next = p.next;
                    p = null;
                    head.data = (Convert.ToInt32(head.data) - 1).ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Reveres(ref LinkListClass L)
        {
            LinkList p = L.head.next,q;
            L.head.next = null;
            while (p != null)
            {
                q = p;
                p = p.next;
                q.next = L.head.next;
                L.head.next = q;
            }
        }
        public int Findlast(LinkListClass L, string x)
        {
            LinkList p = L.head.next;
            int i = 0, j = i;
            while (p != null)
            {
                i++;
                if (p.data == x)
                {
                    j = i;
                }
                p = p.next;
            }

            return j;
        }

        public void DeleteMax(ref string e)
        {
            int max = 0;
            LinkList p = head.next;
            LinkList tmp = head, l1 = head, l2 = head;
            while (p != null)
            {
                if (Convert.ToInt32(p.data) > max)
                {
                    max = Convert.ToInt32(p.data);
                    l1 = tmp;
                    l2 = p;
                }
                tmp = tmp.next;
                p = p.next;
            }
            e = max.ToString();
            l1.next = l2.next;
            l2 = null;
            head.data = (Convert.ToInt32(head.data) - 1).ToString();
        }

        public void Sort() 
        {
            
        }
    }
}
