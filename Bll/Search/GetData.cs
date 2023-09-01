using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Search
{
    public class GetData
    {
        public void GetDataSearch(List<Dto.SearchData> List, string Path)
        {
            Dal.Search.GetData getData = new Dal.Search.GetData();
            getData.GetDataSearch(List,Path);
        }
    }
}
