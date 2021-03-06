﻿using android.content;
using android.os;
using java;
using java.lang;
using System.Text;

using Field = System.Reflection.FieldInfo;
using java.lang.reflect;
using java.util;
using android.app;
using bool = System.Boolean;
using thekit.android;

namespace cn.onekit
{

    public class OneKit
    {
        public static string currentUrl;

        public static void set(System.Object obj, System.Object value, string key)
        {
            try
            {
                Class clazz = obj.getClass();
                Field filed = clazz.getField(key);
                filed.set(obj, value);
            }
            catch (System.Exception e)
            {
                java.Exception_.printStackTrace(e);
            }
        }

        public static System.Object get(System.Object obj, System.Object key)
        {
            try
            {
                Class clazz = obj.getClass();
                Field field = clazz.getDeclaredField((string)key);
                if (field == null)
                {
                    return null;
                }
                return field.get(obj);
            }
            catch (System.Exception e)
            {
                //Log.e("[get]==========", obj + " " +key);
                return null;
            }
        }

        public static string getNameFromUrl(string url)
        {
            return url.substring(url.lastIndexOf("/") + 1);
        }

        public static Bundle querystring2extras(string querystring)
        {
            Bundle extras = new Bundle();
            foreach (string param in java.String_.split(querystring, "&"))
            {
                string[] arr = java.String_.split(param, "=");
                extras.putString(arr[0], arr[1]);
            }
            return extras;
        }

        static string extras2querystring(Bundle extras)
        {
            if (extras == null)
            {
                return "";
            }
            StringBuilder querystring = new StringBuilder();
            int i = 0;
            foreach(string key in extras.keySet())
            {
                if (java.String_.startsWith(key, "onekit_"))
                {
                    continue;
                }
                if (i++ > 0)
                {
                    querystring.append("&");
                }
                querystring.append(String.format("%s=%s", key, extras.getString(key)));
            }
            return querystring.toString();
        }

        public  static Class<Activity> tabsActivityClass;

        public static string class2url(Context context, string clazz)
        {
            if (tabsActivityClass != null && clazz.equals(tabsActivityClass.getName()))
            {
                if (context == null)
                {
                    return "";
                }
            }
            clazz = clazz.substring(context.getPackageName().length() + 1);
            return clazz.substring("onekit_".length()).replace("_", "/");
        }

        public static string class2url(Context context, string clazz, Bundle extras)
        {
            string url = class2url(context, clazz);
            string querystring = extras2querystring(extras);
            if (querystring.length() > 0)
            {
                url += "?" + querystring;
            }
            return url;
        }

        public static string url2class(Context context, string url)
        {
            return context.getPackageName() + ".onekit_" + url.replace("/", "_");
        }

        public static string launchPath(Context context)
        {
            string name = Android.launchActivityName(context);
            return class2url(context, name.substring(1));
        }

        public static string fixPath(string currentUrl, string url)
        {
            if (url.startsWith("/"))
            {
                return url.substring(1);
            }
            ////////////////////
            string folder;
            if (currentUrl.contains("/"))
            {
                folder = currentUrl.substring(0, currentUrl.lastIndexOf("/") + 1);
                if (folder.startsWith("/"))
                {
                    folder = folder.substring(1);
                }
            }
            else
            {
                folder = "";
            }
            url = url.trim();
            if (url.startsWith("./"))
            {
                url = url.substring("./".length());
            }
            while (url.startsWith("../"))
            {
                folder = folder.substring(0, folder.length() - 1);
                folder = folder.substring(0, folder.lastIndexOf("/") + 1);
                url = url.substring("../".length());
            }

            return folder + url;
        }

        //获取唯一UUID
        public static string createUUID()
        {
            StringBuilder uuidStr = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                UUID uuid = UUID.randomUUID();
                string str = uuid.toString().replaceAll("-", "");
                uuidStr.append(str);
            }
            return uuidStr.toString();
        }

        public static string createUUIDfileName(string fileName)
        {
            string uuid = createUUID();
            string ext = fileName.substring(java.String_.lastIndexOf(fileName, "."), fileName.length());
            return uuid + ext;
        }

        public static bool isEmpty(string aString)
        {
            return aString == null || aString.trim().equals("");
        }
        /*
            public static bool isNaN(Object value) {

                if (value == null) {
                    return true;
                }
                if (value is Number) {
                    Number number = (Number) value;
                    return Double.valueOf(number.doubleValue()).equals(Double.NaN);
                }
                if (value is String) {

                    String aString = (String) value;
                    if (aString.equals("NaN")) {
                        return true;
                    }
                    if (aString.equals("")) {
                        return false;
                    }
                    int count = 0;
                    for (char chr : aString.toCharArray()) {
                        if (chr == ' ') {
                            count++;
                        }
                    }
                    if (count == aString.length()) {
                        return false;
                    }
                }

                if (value is java.lang.Boolean) {
                    return false;
                }
                return !isNumber(value);
            }
        */
        public static string firstUppder(string key)
        {
            return key.substring(0, 1).toUpperCase() + key.substring(1);
        }

        public static string firstLower(string key)
        {
            return key.substring(0, 1).toLowerCase() + key.substring(1);
        }
        /*
            public static bool isNumber(JsObject value) {
                if (value == null) {
                    return false;
                }

                if (value is Number) {
                    return !value.equals(Double.NaN);
                }
                try {
                    Double.parseDouble(value.toString());
                    return true;
                } catch (Exception e) {
                    return false;
                }
            }
        */
        public static string toCamelCase(string aString)
        {
            StringBuilder result = new StringBuilder();
            //
            string[] strings = aString.trim().split("-");
            for (int i = 0; i < strings.length(); i++)
            {
                string str = strings[i];
                if (i > 0)
                {
                    str = firstUppder(str);
                }
                result.append(str);
            }
            //
            return result.toString();
        }

        public static string fromCamelCase(string aString)
        {
            StringBuilder result = new StringBuilder();
            //
            foreach (char chr in aString.toCharArray())
            {
                if (result.length() > 0)
                {
                    if (chr >= 'A' && chr <= 'Z')
                    {
                        result.append("-");
                    }
                }
                result.append(String.valueOf(chr).toLowerCase());
            }
            //
            return result.toString();
        }
    }

}
