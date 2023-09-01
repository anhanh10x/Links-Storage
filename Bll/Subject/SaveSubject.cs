using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Subject
{
    public class SaveSubject
    {
        public void SaveDataSubject(string Path, List<Dto.Subject> SubjectList)
        {
            Dal.Subject.SaveSubject saveSubject = new Dal.Subject.SaveSubject();
            saveSubject.SaveDataSubject(Path, SubjectList);
        }
    }
}
