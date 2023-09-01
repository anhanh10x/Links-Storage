namespace Dto
{
    public class Link
    {
        private string accountName = "";
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        private string timeStamp = "";
        public string TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }
        private string url = "";
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        private string title = "";
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string iconImage = "";
        public string IconImage
        {
            get { return iconImage; }
            set { iconImage = value; }
        }
        public Link(string Titile = "", string Url = "", string IconImage = "", string AccountName = "", string TimeStamp = "")
        {
            title = Titile;
            url = Url;
            iconImage = IconImage;
            accountName = AccountName;
            timeStamp = TimeStamp;
        }
    }
}