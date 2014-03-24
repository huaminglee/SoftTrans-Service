using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.Common
{
    public class JsonManager
    {
        public static string WriteJson(Dictionary<string, object> data)
        {
            using (StringWriter strWriter = new StringWriter())
            {
                using (JsonTextWriter jsonWriter = new JsonTextWriter(strWriter))
                {
                    jsonWriter.WriteStartArray();
                    jsonWriter.WriteStartObject();
                    foreach (var item in data.Keys)
                    {
                        jsonWriter.WritePropertyName(item);
                        jsonWriter.WriteValue(data[item]);
                    }
                    jsonWriter.WriteEndObject();
                    jsonWriter.WriteEndArray();
                    jsonWriter.Flush();

                    return strWriter.GetStringBuilder().ToString();
                }
            }
        }

        public static List<string> SplitJson(string json)
        {
            List<string> items = new List<string>();

            if (json.Contains("[{"))//多条数据
            {
                int start = json.IndexOf("[{") + 1;
                json = json.Substring(start, json.LastIndexOf("}]"));

                string splitKey = "},{";
                start = json.IndexOf(splitKey);
                while (start > -1)
                {
                    items.Add(json.Substring(0, start + 1));
                    json = json.Remove(0, start + 2);
                    start = json.IndexOf(splitKey);
                }
            }
            items.Add(json);

            return items;
        }

        public static Dictionary<string, string> Split(string json)
        {
            if (string.IsNullOrEmpty(json) || !json.StartsWith("{") || !json.EndsWith("}"))
            {
                return null;
            }
            json = json.TrimStart('{').TrimEnd('}');
            List<string> items = new List<string>();
            string splitKey = "\",\"";
            int index = json.IndexOf(splitKey);
            if (index == -1)
            {
                splitKey = "','";
                index = json.IndexOf(splitKey);
                if (index == -1)
                {
                    splitKey = ",";
                    index = json.IndexOf(splitKey);
                }
            }
            int startIndex = 0;
            string item = string.Empty;
            while (index > -1)
            {
                item = json.Substring(0, index + 1);
                if (item.Contains(":"))
                {
                    items.Add(item);
                    json = json.Remove(0, index + 2);
                    startIndex = 0;
                }
                else
                {
                    startIndex = index + 2;
                }
                index = json.IndexOf(splitKey, startIndex);
            }
            items.Add(json);
            Dictionary<string, string> keyValueDic = null;
            if (items.Count > 0)
            {
                keyValueDic = new Dictionary<string, string>();
                foreach (string keyValue in items)
                {
                    index = keyValue.IndexOf(':');
                    if (index > -1)
                    {
                        keyValueDic.Add(keyValue.Substring(0, index).Trim('\'', '\"'), keyValue.Substring(index + 1).Trim('\'', '\"'));
                    }
                }
            }
            return keyValueDic;
        }
    }
}
