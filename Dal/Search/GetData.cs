using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Dal.Search
{
    public class GetData
    {
        public void GetDataSearch(List<Dto.SearchData> List, string Path)
        {
            string Data = "";
            StreamReader streamReader = new StreamReader(Path + "\\SearchDataHistory.txt");

            Data = streamReader.ReadToEnd();
            streamReader.Close();

            Regex regex = new Regex(@"<Author>(?<Author>.+)<\/Author><Subject>(?<Subject>.+)<\/Subject><Titile>(?<Titile>.+)<\/Titile><Url>(?<Url>.+)<\/Url>");
            MatchCollection Collection = regex.Matches(Data);
            if (Collection.Count <= 0)
                return;

            foreach (Match Element in Collection)
            {
                Dto.SearchData searchData = new Dto.SearchData();
                searchData.Author = Element.Groups["Author"].ToString();
                searchData.Subject = Element.Groups["Subject"].ToString();
                searchData.Titile = Element.Groups["Titile"].ToString();
                searchData.Url = Element.Groups["Url"].ToString();
                List.Add(searchData);
            }
            
        }
    }
}
