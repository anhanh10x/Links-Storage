using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Subject
{
    public class SaveSubject
    {
        public void SaveDataSubject(string Path, List<Dto.Subject> SubjectList)
        {
            string temp = "";
            StreamWriter streamWriter = new StreamWriter(Path + "\\SubjectList.txt", false);
            foreach (Dto.Subject subject in SubjectList)
            {
                temp = "<Subject>" + subject.SubjectName + "</Subject><Icon>" + subject.Icon + "</Icon><SubjectColor>" + subject.SubjectColor + "</SubjectColor>";
                streamWriter.WriteLine(temp);
            }
            streamWriter.Close();
        }
    }
}
