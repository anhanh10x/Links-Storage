using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Subject
    {
        private string subjectName = "";
        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        private string icon = "";
        public string Icon
        { get { return icon; } set { icon = value; } }

        private string subjectColor = "";
        public string SubjectColor
        {
            get { return subjectColor; }
            set { subjectColor = value; }
        }

        public Subject(string SubjectName = "", string Icon = "", string SubjectColor = "")
        {
            this.subjectName = SubjectName;
            this.Icon = Icon;
            this.subjectColor = SubjectColor;
        }
    }
}