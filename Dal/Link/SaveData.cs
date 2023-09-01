using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Dal.Link
{
    public class SaveData
    {
        public void SaveLink(string FileName, List<Dto.Link> List, string Path)
        {
            StreamWriter streamWriter = new StreamWriter(Path + "\\" + FileName + ".txt");
            foreach (Dto.Link Link in List)
            {
                string Temp = "<Author>" + Link.AccountName + "</Author><Time>" + Link.TimeStamp + "</Time><Titile>" + Link.Title + "</Titile><Link>" + Link.Url + "</Link><ImageIcon>" + Link.IconImage + "</ImageIcon>";
                streamWriter.WriteLine(Temp);
            }
            streamWriter.Close();
        }
    }
}
