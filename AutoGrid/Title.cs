using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;


namespace AutoGrid
{
    public class Title : Attribute, ITitle
    {
        public Title(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
    public static class GetTitlesExtensions
    {

        public static string GetTitle(this Type type)
        {
            var title = (Title)type.GetCustomAttributes(false).First(a => a.GetType() == typeof(Title));
            return title.Name;
        }
        public static IEnumerable<string> GetTitlesProperty(this Type type)
        {
            return GetPropertyAttributes<Title>(type).Select(x => x.Name);
        }

        public static IEnumerable<T> GetPropertyAttributes<T>(this Type type) where T : Attribute => 
            type.GetProperties().Select(t => (T)t.GetCustomAttribute(typeof(T))).Where(title => title != null).ToArray();

        public static IEnumerable<KeyValuePair<PropertyInfo, T>> GetPropertiesWithAttribute<T>(this Type type) where T : Attribute => 
            type.GetProperties().Select(t => new KeyValuePair<PropertyInfo, T>(t, (T)t.GetCustomAttribute(typeof(T)))).Where(pair => pair.Value != null);

        public static string GetTitleValue(this Enum enumVal)
        {
            var valueName = enumVal.ToString();
            return GetTitleValue(enumVal, valueName);
        }


        private static string GetTitleValue(Enum enumVal, string valueName)
        {
            var title = (Title)enumVal.GetType().GetMember(valueName)[0].GetCustomAttribute(typeof(Title), false);
            return title.Name;
        }
        public static Dictionary<string, string> GetTitlesValue(this Enum enumVal)
        {
            var dic = new Dictionary<string, string>();
            var names = enumVal.GetType().GetEnumNames();
            foreach (var name in names)
            {
                string title = GetTitleValue(enumVal, name);
                if (title != null)
                {
                    dic.Add(name, title);
                }

            }

            return dic;
        }
    }
}
