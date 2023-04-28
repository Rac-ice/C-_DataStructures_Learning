using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLinkList
{

    class DLinkList
    {
        public string data;
        public DLinkList prior;
        public DLinkList next;
    }
    public class DLinkListClass
    {
        DLinkList dhead = new DLinkList();
    }
}
