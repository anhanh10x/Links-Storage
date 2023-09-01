using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bll.Link
{
    public class SaveData
    {
        public void SaveLink(string FileName, List<Dto.Link> List, string Path)
        {
            Dal.Link.SaveData saveData = new Dal.Link.SaveData();
            saveData.SaveLink(FileName, List, Path);
        }
    }
}
