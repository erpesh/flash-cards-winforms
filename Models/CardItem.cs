using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class CardItem
    {
        private string term;
        private string definition;
        private bool isStarred;
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
        public bool IsStarred
        {
            get { return isStarred; }
            set { isStarred = value; }
        }
        public CardItem(string term, string definition, string isStarred = "0")
        {
            this.term = term;
            this.definition = definition;
            this.isStarred = isStarred == "1";
        }
    }
}
