using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class CardItem
    {
        private string _term;
        private string _definition;
        public string Term
        {
            get { return _term; }
            set { _term = value; }
        }
        public string Definition
        {
            get { return _definition; }
            set { _definition = value; }
        }
    }
}
