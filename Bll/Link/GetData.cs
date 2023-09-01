using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Link
{
    public class GetData
    {
        public void ReadData(string Title, List<Dto.Link> List, string Path, bool isFullPath = false)
        {   
            Dal.Link.GetData getData = new Dal.Link.GetData();
            if(isFullPath == false)
            {
                Path = Path + "\\" + Title + ".txt";
            }
            getData.ReadData(Title, List, Path);
        }
    }
}
