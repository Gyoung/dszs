using LeafSoft.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;

namespace LeafSoft.Units
{
    public class XmlUnits
    {
        public static string saveXml(BindingList<CMD> dataSource)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root= doc.CreateElement("root");
            XmlElement firstChild = doc.CreateElement("command");
            doc.AppendChild(root);
            root.SetAttribute("name", "101025");
            for(int i = 0; i < dataSource.Count; i++)
            {
                XmlElement cmdEle = doc.CreateElement("cmd");
                CMD cmd = dataSource[i];
                cmdEle.SetAttribute("remark", cmd.Remark);
                cmdEle.SetAttribute("text", cmd.Text);
                cmdEle.SetAttribute("type", cmd.ContentType.ToString());
                root.AppendChild(cmdEle);
            }
            string dir = AppDomain.CurrentDomain.BaseDirectory+"File";
            string fileName = dir + "\\data.xml";
            root.SetAttribute("file", fileName);
            doc.Save(fileName);
            return fileName;
        } 
    }
}
