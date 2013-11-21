using UnityEngine;
using System.Collections;
using System.Xml;

public class XMLHelper : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("E:\\test.xml");
        foreach (XmlNode node in doc.GetElementsByTagName("packet"))
            GetNodes(node);
    }
    static void GetNodes(XmlNode node)
    {
        XmlAttribute showname = node.Attributes["showname"];
        XmlAttribute show = node.Attributes["show"];
        XmlAttribute value = node.Attributes["value"];
        if (showname != null || show != null || value != null)
        {
            //Console.Write("tagname:{0} ", node.Name);
            //if (showname != null)
            //    Console.Write("showname:{0} ", showname.Value);
            //if (show != null)
            //    Console.Write("show:{0} ", show.Value);
            //if (value != null)
            //    Console.Write("value:{0} ", value.Value);
            //Console.WriteLine();
        }
        foreach (XmlNode xn in node.ChildNodes)
            GetNodes(xn);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
