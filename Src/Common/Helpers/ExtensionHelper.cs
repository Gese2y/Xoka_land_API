using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace XOKA.Common.Helpers
{
    public class KeyVal<Key, Val>
    {
        public Key Id { get; set; }
        public Val Text { get; set; }

        public KeyVal() { }

        public KeyVal(Key key, Val val)
        {
            this.Id = key;
            this.Text = val;
        }
    }
    public static class ExtensionHelper
    {
        public static KeyVal<string, object>[] AsDictionary(this object source, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
        {
            List<KeyVal<string, object>> keyVals = new List<KeyVal<string, object>>();
            Dictionary<string, object> myDict = new Dictionary<string, object>();
            Type t = source.GetType();
            foreach (PropertyInfo pi in t.GetProperties())
            {
                myDict[pi.Name] = pi.GetValue(source, null)?.ToString();

            }
   

            foreach(var item in myDict)
            {
                keyVals.Add(new KeyVal<string, object> { Id = item.Key, Text = item.Value });
            }

            return keyVals.ToArray();
        }
        public static string ToNamedParams(this string Input)
        {
            if(Input.EndsWith("Active") || Input.EndsWith("Date"))
            {
                return Input;
            }
            return new string(Input.SelectMany((c, i) => i > 0 && char.IsUpper(c) ? new[] { '_', c } : new[] { c }).ToArray());
        }

        
    }
     
}
