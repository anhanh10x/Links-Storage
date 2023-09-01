using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Dto;
namespace Dal.Link
{
    public class GetData
    {
        public void ReadData(string FileName, List<Dto.Link> List,string Path)
        {
            string Data = "";
            if (File.Exists(Path) == true)
            {
                StreamReader streamReader = new StreamReader(Path);

                Data = streamReader.ReadToEnd();
                streamReader.Close();
                
                Regex regex = new Regex(@"<Author>(?<Author>.+)<\/Author><Time>(?<Time>.+)<\/Time><Titile>(?<Titile>.+)<\/Titile><Link>(?<Link>.+)<\/Link><ImageIcon>(?<ImageIcon>.+)<\/ImageIcon>");
                MatchCollection Collection = regex.Matches(Data);
                foreach (Match Element in Collection)
                {
                    Dto.Link link = new Dto.Link();
                    link.Title = Element.Groups["Titile"].ToString();
                    link.Url = Element.Groups["Link"].ToString();
                    link.IconImage = Element.Groups["ImageIcon"].ToString();
                    link.AccountName = Element.Groups["Author"].ToString();
                    link.TimeStamp = Element.Groups["Time"].ToString();
                    List.Add(link);
                }
            }
        }
    }
}
