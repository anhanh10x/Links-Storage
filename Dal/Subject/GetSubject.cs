using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Dto;

namespace Dal.Subject
{
    public class GetSubject
    {
        public void GetDataSubject(string Path, List<Dto.Subject> List)
        {
            if (File.Exists(Path + "\\SubjectList.txt") == true)
            {
                StreamReader streamReader = new StreamReader(Path + "\\SubjectList.txt");
                string Data = streamReader.ReadToEnd();
                streamReader.Close();

                Regex regex = new Regex(@"<Subject>(?<Subject>.+)<\/Subject><Icon>(?<Icon>.+)<\/Icon><SubjectColor>(?<SubjectColor>.+)<\/SubjectColor");
                MatchCollection Collection = regex.Matches(Data);
                foreach (Match Element in Collection)
                {
                    Dto.Subject subject = new Dto.Subject();
                    subject.SubjectName = Element.Groups["Subject"].ToString();
                    subject.Icon = Element.Groups["Icon"].ToString();
                    subject.SubjectColor = Element.Groups["SubjectColor"].ToString();
                    List.Add(subject);
                }
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(Path + "\\SubjectList.txt", true);
                streamWriter.Close();
            }
        }
    }
}
