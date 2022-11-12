using System;

namespace AddressbookUiSelenium.Models
{
    public class Group
    {
        private int id;
        private string groupName;
        private string groupHeader;
        private string groupFooter;

        public string GroupHeader
        {
            get => groupHeader;
            set => groupHeader = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string GroupFooter => groupFooter;


        public string GroupName
        {
            get => groupName;
            set => groupName = value;
        }


        public Group withName(string groupName)
        {
            this.groupName = groupName;
            return this;
        }

        public Group withHeader(string groupHeader)
        {
            this.groupHeader = groupHeader;
            return this;
        }

        public Group withFooter(string groupFooter)
        {
            this.groupFooter = groupFooter;
            return this;
        }

        public Group withId(int id)
        {
            this.id = id;
            return this;
        }

        protected bool Equals(Group other)
        {
            return id == other.id && groupName == other.groupName && groupHeader == other.groupHeader &&
                   groupFooter == other.groupFooter;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Group) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, groupName, groupHeader, groupFooter);
        }

        public override string ToString()
        {
            return "{" +
                   "id = " + id + "," +
                   "groupName = " + "\""+groupName+"\"" + "," +
                   "groupHeader = " + "\""+groupHeader+"\"" + "," +
                   "groupFooter = " + "\""+groupFooter +"\"" + "}";
        }
    }
}