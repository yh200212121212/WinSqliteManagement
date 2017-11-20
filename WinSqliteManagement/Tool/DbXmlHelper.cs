using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Text;
using System.Xml;
//using System.Xml.Linq;

namespace WinSqliteManagement
{
    #region DbXmlHelper
    //public class DbXmlHelper
    //{
    //    private static List<DbXmlInfo> dbList = new List<DbXmlInfo>();

    //    private static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.xml");

    //    static DbXmlHelper()
    //    {
    //        string xmlContent = File.ReadAllText(path, Encoding.UTF8);
    //        using (TextReader reader = new StringReader(xmlContent))
    //        {
    //            var doc = XDocument.Load(reader);
    //            var nodes = doc.Element("Root").Elements("Db");
    //            foreach (XElement node in nodes)
    //            {
    //                var item = new DbXmlInfo();
    //                item.Name = node.Attribute("Name").Value;
    //                item.Path = node.Attribute("Path").Value;
    //                item.Pwd = node.Attribute("Pwd").Value;

    //                dbList.Add(item);
    //            }
    //        }
    //    }

    //    public static List<DbXmlInfo> GetList()
    //    {
    //        lock (dbList)
    //        {
    //            return dbList;
    //        }
    //    }

    //    public static DbXmlInfo GetItem(string name)
    //    {
    //        lock (dbList)
    //        {
    //            return dbList.Find(p => p.Name == name);
    //        }
    //    }

    //    public static void AddList(DbXmlInfo info)
    //    {
    //        lock (dbList)
    //        {
    //            var item = dbList.Find(p => p.Name == info.Name);
    //            if (item == null)
    //            {
    //                dbList.Add(item);
    //            }
    //            else
    //            {
    //                string name = info.Name;
    //                int index = 1;
    //                while (item != null)
    //                {
    //                    info.Name = name + "_" + index;
    //                    item = dbList.Find(p => p.Name == info.Name);
    //                }

    //                dbList.Add(info);
    //            }

    //            SaveXml();
    //        }
    //    }

    //    public static void EditList(DbXmlInfo info)
    //    {
    //        lock (dbList)
    //        {
    //            var item = dbList.Find(p => p.Guid == info.Guid);
    //            item = info;

    //            SaveXml();
    //        }
    //    }

    //    private static void SaveXml()
    //    {
    //        StringBuilder content = new StringBuilder();
    //        content.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
    //        content.AppendLine("<Root>");
    //        foreach (var item in dbList)
    //        {
    //            content.AppendFormat("  <Db Guid=\"{3}\" Name=\"{0}\" Path=\"{1}\" Pwd=\"{2}\" />", item.Name, item.Path, item.Pwd ?? string.Empty, item.Guid);
    //        }

    //        content.AppendLine("</Root>");

    //        File.WriteAllText(path, content.ToString(), Encoding.UTF8);
    //    }
    //}
    #endregion

    public class DbXmlHelper
    {
        private static List<DbXmlInfo> dbList = new List<DbXmlInfo>();

        private static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB.xml");

        static DbXmlHelper()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            //使用xpath表达式选择文档中所有的student子节点
            XmlNodeList studentNodeList = doc.SelectNodes("/Root/Db");
            if (studentNodeList != null)
            {
                foreach (XmlNode studentNode in studentNodeList)
                {
                    //通过Attributes获得属性名字为name的属性
                    string guid = studentNode.Attributes["Guid"].Value;
                    string name = studentNode.Attributes["Name"].Value;
                    string dbPath = studentNode.Attributes["Path"].Value;
                    string pwd = studentNode.Attributes["Pwd"].Value;

                    dbList.Add(new DbXmlInfo()
                    {
                        Guid = guid,
                        Name = name,
                        Path = dbPath,
                        Pwd = pwd
                    });
                }
            }
        }

        public static List<DbXmlInfo> GetList()
        {
            lock (dbList)
            {
                return dbList;
            }
        }

        public static DbXmlInfo GetItem(string name)
        {
            lock (dbList)
            {
                return dbList.Find(p => p.Name == name);
            }
        }

        public static void AddList(DbXmlInfo info)
        {
            lock (dbList)
            {
                var item = dbList.Find(p => p.Name == info.Name);
                if (item == null)
                {
                    dbList.Add(item);
                }
                else
                {
                    string name = info.Name;
                    int index = 1;
                    while (item != null)
                    {
                        info.Name = name + "_" + index;
                        item = dbList.Find(p => p.Name == info.Name);
                    }

                    dbList.Add(info);
                }

                SaveXml();
            }
        }

        public static void EditList(DbXmlInfo info)
        {
            lock (dbList)
            {
                var item = dbList.Find(p => p.Guid == info.Guid);
                item = info;

                SaveXml();
            }
        }

        private static void SaveXml()
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            content.AppendLine("<Root>");
            foreach (var item in dbList)
            {
                content.AppendFormat("  <Db Guid=\"{3}\" Name=\"{0}\" Path=\"{1}\" Pwd=\"{2}\" />", item.Name, item.Path, item.Pwd ?? string.Empty, item.Guid);
            }

            content.AppendLine("</Root>");

            File.WriteAllText(path, content.ToString(), Encoding.UTF8);
        }
    }

    public class DbXmlInfo
    {
        public string Guid { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string Pwd { get; set; }
    }
}
