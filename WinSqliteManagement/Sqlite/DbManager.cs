using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Text;

namespace WinSqliteManagement
{
    public class DbManager
    {
        public static string CreateConnectionStr(string dbPath, string password)
        {
            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException("文件" + dbPath + "不存在!");
            }

            System.Data.SQLite.SQLiteConnectionStringBuilder connstr = new System.Data.SQLite.SQLiteConnectionStringBuilder();
            connstr.DataSource = dbPath;
            if (!string.IsNullOrEmpty(password))
            {
                connstr.Password = password;
            }

            return connstr.ToString();
        }

        public static List<string> ReadAllTables(string dbPath, string password)
        {
            List<string> result = new List<string>();
            string selectTableStr = "select name from sqlite_master where type='table' order by name;";
            string connectStr = CreateConnectionStr(dbPath, password);
            using (DbDataReader dr = SQLiteHelper.ExecuteReader(connectStr, selectTableStr, System.Data.CommandType.Text))
            {
                while (dr.Read())
                {
                    result.Add(dr["name"] == DBNull.Value ? string.Empty : dr["name"].ToString());
                }
            }

            return result;
        }

        public static List<string> ReadTableStructure(string dbPath, string password, string tableName)
        {
            List<string> result = new List<string>();
            string selectTableStruct = "PRAGMA table_info('" + tableName + "')";
            string connectStr = CreateConnectionStr(dbPath, password);
            using (DbDataReader dr = SQLiteHelper.ExecuteReader(connectStr, selectTableStruct, System.Data.CommandType.Text))
            {
                while (dr.Read())
                {
                    List<string> list = new List<string>();
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        list.Add(dr.GetValue(i).ToString());
                    }

                    string value = string.Empty;
                    if (list.Count > 0)
                    {
                        value = string.Join("|", list.ToArray());
                    }

                    result.Add(value);
                }
            }

            return result;
        }

        public static DataSet ReadTableContent(string dbPath, string password, string tableName)
        {
            List<string> result = new List<string>();
            string selectSql = "select * from " + tableName + "";
            string connectStr = CreateConnectionStr(dbPath, password);
            DataSet ds = SQLiteHelper.ExecuteDataSet(connectStr, selectSql, System.Data.CommandType.Text);

            return ds;
        }
    }
}
