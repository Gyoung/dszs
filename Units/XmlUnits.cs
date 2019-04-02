using LeafSoft.Lib;
using LeafSoft.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;

namespace LeafSoft.Units
{
    public class XmlUnits
    {
        static string  fileName = AppDomain.CurrentDomain.BaseDirectory + "File\\";

        public static string saveXml(BindingList<CMD> dataSource,Command command,string tabName)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root= doc.CreateElement("root");
            XmlElement firstChild = doc.CreateElement("command");
            doc.AppendChild(root);
            if (command != null)
            {
                root.SetAttribute("Com", command.Com);
                root.SetAttribute("Ptl", command.Ptl);
                root.SetAttribute("Sjw", command.Sjw);
                root.SetAttribute("Tzw", command.Tzw);
                root.SetAttribute("Xjw", command.Xjw);
            }
            for (int i = 0; i < dataSource.Count; i++)
            {
                XmlElement cmdEle = doc.CreateElement("cmd");
                CMD cmd = dataSource[i];
                cmdEle.SetAttribute("remark", cmd.Remark);
                cmdEle.SetAttribute("text", cmd.Text);
                cmdEle.SetAttribute("type", cmd.ContentType.ToString());
                root.AppendChild(cmdEle);
            }
            string ffName = fileName + "data_" + tabName + ".xml";
            doc.Save(ffName);
            return ffName;
        }
        
        public static BindingList<CMD> getXmlData(string tabName)
        {
            BindingList<CMD> dataSource = new BindingList<CMD>();
            XmlDocument doc = new XmlDocument();
            string fullName = fileName + "data_" + tabName + ".xml";
            if (!File.Exists(fullName))
            {
                return dataSource;
            }
            doc.Load(fullName);
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodeList = root.ChildNodes;
            foreach (XmlElement node in nodeList)
            {
                string type = node.GetAttribute("type");
                string text = node.GetAttribute("text");
                string remark = node.GetAttribute("remark");
                EnumType.CMDType cmdType = EnumType.CMDType.ASCII;
                byte[] data = null;
                if(type== "ASCII")
                {
                    data = new ASCIIEncoding().GetBytes(text);
                }
                else
                {
                    data = getByte(text);
                    cmdType = EnumType.CMDType.Hex;
                }
                CMD cmd = new CMD(cmdType, data, remark);
                dataSource.Add(cmd);
            }
            return dataSource;
        }

        public static Command getCommandData(string tabName)
        {
            Command command = new Command();
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName + "data_" + tabName + ".xml");
            XmlElement root = doc.DocumentElement;
            command.Com = root.GetAttribute("Com");
            command.Ptl = root.GetAttribute("Ptl");
            command.Sjw = root.GetAttribute("Sjw");
            command.Tzw = root.GetAttribute("Tzw");
            command.Xjw = root.GetAttribute("Xjw");
            return command;
        }


        public static byte[] getByte(string text)
        {
            string[] HexStr = text.Trim().Split(' ');
            byte[] data = new byte[HexStr.Length];
            for (int i = 0; i < HexStr.Length; i++)
            {
                data[i] = (byte)(Convert.ToInt32(HexStr[i], 16));
            }
            return data;
        }



        public static string saveType(List<TypeData> dataSource)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("root");
            doc.AppendChild(root);
            for (int i = 0; i < dataSource.Count; i++)
            {
                XmlElement cmdEle = doc.CreateElement("type");
                TypeData type = dataSource[i];
                cmdEle.SetAttribute("type", type.Type);
                cmdEle.SetAttribute("name", type.Name);
                cmdEle.SetAttribute("value1", type.Value1);
                cmdEle.SetAttribute("value2", type.Value2);
                cmdEle.SetAttribute("dropType", type.DropType);
                cmdEle.SetAttribute("minValue", type.MinValue);
                cmdEle.SetAttribute("maxValue", type.MaxValue);
                root.AppendChild(cmdEle);
            }
            string ffName = fileName + "type.xml";
            doc.Save(ffName);
            return ffName;
        }

        public static List<TypeData> getTypeData()
        {
            List<TypeData> dataSource = new List<TypeData>();
            XmlDocument doc = new XmlDocument();
            string fullName = fileName + "type.xml";
            if (!File.Exists(fullName))
            {
                return dataSource;
            }
            doc.Load(fullName);
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodeList = root.ChildNodes;
            foreach (XmlElement node in nodeList)
            {
                TypeData type = new TypeData();
                type.Type = node.GetAttribute("type");
                type.Name = node.GetAttribute("name");
                type.Value1 = node.GetAttribute("value1");
                type.Value2 = node.GetAttribute("value2");
                type.DropType = node.GetAttribute("dropType");
                type.MinValue = node.GetAttribute("minValue");
                type.MaxValue = node.GetAttribute("maxValue");
                dataSource.Add(type);
            }
            return dataSource;
        }


        public static List<Device> getDeviceData()
        {
            List<Device> dataSource = new List<Device>();
            string fullName = fileName + "DeviceAddr.csv";
            if (!File.Exists(fullName))
            {
                return dataSource;
            }
            using (StreamReader reader = new StreamReader(fullName,Encoding.Default))
            {
                while (reader.Peek() > -1)
                {
                    Device dv = new Device();
                    string line = reader.ReadLine();
                    string[] items = line.Split(',');
                    if (items.Length > 0)
                    {
                        dv.Name = items[0];
                    }
                    if (items.Length > 1)
                    {
                        dv.Id = items[1];
                    }
                    if (items.Length > 2)
                    {
                        dv.Address = items[2];
                    }
                    dataSource.Add(dv);
                }
            }
            return dataSource;
        }

    }
}
