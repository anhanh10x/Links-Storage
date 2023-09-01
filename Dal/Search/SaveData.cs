using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Search
{
    public class SaveData
    {
        public void SaveDataSearch(List<Dto.SearchData> List, string Path)
        {
            StreamWriter streamWriter = new StreamWriter(Path + "\\SearchDataHistory.txt", true);
            foreach (Dto.SearchData searchData in List)
            {
                string Temp = "<Author>" + searchData.Author + "</Author><Subject>" + searchData.Subject + "</Subject><Titile>" + searchData.Titile + "</Titile><Url>" + searchData.Url + "</Url>";
                streamWriter.WriteLine(Temp);
            }
            streamWriter.Close();
        }
    }
}
