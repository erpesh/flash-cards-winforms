using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class CardItem
    {
        // data
        private string term;
        private string definition;
        private bool isStarred;

        // getters setters
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
        // constructor
        public CardItem(string term, string definition, string isStarred = "0")
        {
            this.term = term;
            this.definition = definition;
            this.isStarred = isStarred == "1";
        }
    }
}
