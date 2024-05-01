using System.Xml;

namespace ReadXMLfromURL
{
   
    class Class1
    {
        static void Main(string[] args)
        {
            String URLString = "https://www.w3schools.com/xml/cd_catalog.xml";
            XmlTextReader reader = new XmlTextReader(URLString);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: 
                        Console.Write("<" + reader.Name);

                        while (reader.MoveToNextAttribute()) 
                            Console.Write(" " + reader.Name + "='" + reader.Value + "'");
 
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: 
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: 
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
        }
    }
}