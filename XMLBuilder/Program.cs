using System;

namespace XMLBuilder
{
    class Program
    {
        class xmlBuilder
        {
            private string xml;
            public xmlBuilder()
            {
                this.xml = "";
            }
            public xmlBuilder beginTag(string value)
            {
                //this.xml = this.xml + "<" + value + ">";
                this.xml += "<" + value + ">\n";
                return this;
            }

            public xmlBuilder endTag(string value)
            {
                //this.xml = this.xml + "</" + value + ">";
                this.xml += "</" + value + ">";
                return this;
            }
            public xmlBuilder beginTag2(string value)
            {
                //this.xml = this.xml + "<" + value + ">";
                this.xml += "<" + value + ">";
                return this;
            }
            public xmlBuilder setContent2(string value)
            {
                //this.xml = this.xml + value;
                this.xml += value;
                return this;
            }
            public xmlBuilder endTag2(string value)
            {
                //this.xml = this.xml + "</" + value + ">";
                this.xml += "</" + value + ">\n";
                return this;
            }
            public xmlBuilder beginTag3(string value)
            {
                //this.xml = this.xml + "<" + value + ">";
                this.xml += "<" + value + ">";
                return this;
            }
            public xmlBuilder setContent3(string value)
            {
                //this.xml = this.xml + value;
                this.xml += value;
                return this;
            }
            public xmlBuilder endTag3(string value)
            {
                //this.xml = this.xml + "</" + value + ">";
                this.xml += "</" + value + ">\n";
                return this;
            }

            public string getXML()
            {
                return this.xml;
            }
        }
        static void Main(string[] args)
        {
            xmlBuilder xml = new xmlBuilder();
            string x = xml.beginTag("note").beginTag2("from").setContent2("Hussain").endTag2("from").beginTag3("body").setContent3("Do Not Use Your Bag").endTag3("body").endTag("note").getXML();
            Console.Write(x);
        }
    }
}
