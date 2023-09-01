using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Search
{
    public class SaveData
    {
        public void SaveDataSearch(List<Dto.SearchData> List, string Path)
        {
            Dal.Search.SaveData saveData = new Dal.Search.SaveData();
            saveData.SaveDataSearch(List, Path);
        }
    }
}
