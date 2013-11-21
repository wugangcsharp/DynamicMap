using UnityEngine;
using System.Collections;
using System.Xml;

public class XMLHelper : MonoBehaviour
{
    XmlDocument doc;
	
	XmlNodeList nodeList;
	 
    // Use this for initialization
    void Start()
    {
        doc = new XmlDocument();
        doc.Load(Application.dataPath+@"/XMLData/Terrain1.xml");
		nodeList=doc.SelectSingleNode("root").ChildNodes;
    }

    void OnGUI()
    {
		if(nodeList==null)return;
//		for (int i = 0; i < parentNode.ChildNodes.Count; i++) {
//			 XmlNode  node=parentNode.ChildNodes[i];
//			  XmlAttribute PX = node.Attributes["PX"];
//			  GUI.Label(new Rect(100, 100, 300, 40), PX.Value);
//		}
		
		foreach (XmlNode node in nodeList) {
			 XmlAttribute  px=node.Attributes["PX"];
			 GUI.Label(new Rect(100, 100, 300, 40), px.Value);
		}
    }
}
