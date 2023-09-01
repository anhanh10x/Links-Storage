using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Subject
{
    public class GetSubject
    {
        public void GetDataSubject(string Path, List<Dto.Subject> List)
        {
            Dal.Subject.GetSubject getSubject = new Dal.Subject.GetSubject();
            getSubject.GetDataSubject(Path,List);
        }
    }
}
