using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class CardItem
    {
        private string term;
        private string definition;
        public string Term
        {
            get { return term; }
            set { term = value; }
        }
        public string Definition
        {
            get { return definition; }
            set { definition = value; }
        }
    }
}
