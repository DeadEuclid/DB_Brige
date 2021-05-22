using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;


namespace AutoGrid
{
    public class Title : Attribute
    {
        public Title(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
    public class AddableBDTitle:Attribute
    {
        public AddableBDTitle(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
    public static class GetTitlesExtensions
    {

        public static string GetTitle(this Type type)
        {
            var title = (Title)type.GetCustomAttributes(false).Where(a => a.GetType() == typeof(Title)).First();
            return title.Name;
        }
        public static string[] GetTitlesPropery(this Type type)
        {
            return type.GetProperties().Select(t => (Title)t.GetCustomAttribute(typeof(Title))).Select(title => title?.Name ).Where(title=>title != null).ToArray();
        }
        public static string GetTitleValue(this Enum enumVal)
        {
             var valueName= enumVal.ToString();
           return GetTitleValue(enumVal, valueName);
        }
        private static string GetTitleValue(Enum enumVal,string valueName)
        {
            var title = (Title)enumVal.GetType().GetMember(valueName)[0].GetCustomAttribute(typeof(Title), false);
            return title.Name;
        }
        public static Dictionary<string, string> GetTitlesValue(this Enum enumVal)
        {
            var dic = new Dictionary<string,string>();
            var names = enumVal.GetType().GetEnumNames();
            foreach (var name in names)
            {
                string title = GetTitleValue(enumVal, name);
                if (title!=null)
                {
                     dic.Add(name,title );
                }

            }

            return dic;
        }
    }
}
