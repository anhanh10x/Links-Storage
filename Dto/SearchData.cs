using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class SearchData
    {
        private string author = "";
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string subject = "";
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        private string titile = "";
        public string Titile
        {
            get { return titile; }
            set { titile = value; }
        }

        private string url = "";
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        public SearchData(string Author ="", string Subject = "", string Titile = "", string Url= "")
        {
            this.author = Author;
            this.subject = Subject;
            this.titile = Titile;
            this.url = Url;
        }
    }
}
