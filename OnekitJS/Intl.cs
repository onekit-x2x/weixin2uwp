using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Intl
    {
        static List<string> allLocale;

        static {
        allLocale = new ArrayList<>();
        for (java.util.Locale local : java.util.Locale.getAvailableLocales()) {
            allLocale.Add(local.ToString().replace("_", "-").toUpperCase());
        }
}

public static Array getCanonicalLocales(Array locales)
{
    Array result = new Array();
    for (object temp : locales) {
    string locale = ((string)temp).THIS;
    if (!allLocale.contains(locale.toUpperCase()))
    {
        throw new RangeError(new string(string.Format("invalid language tag: %s", locale)));
    }
    string str;
    if (locale.contains("-"))
    {
        string[] language_nation = locale.split("-");
        string language = language_nation[0].toLowerCase();
        string nation = language_nation[1].toUpperCase();
        str = string.Format("%s-%s", language, nation);
    }
    else
    {
        str = locale.toLowerCase();
    }
    result.Add(new string(str));
}
return result;
    }

    public static Array getCanonicalLocales(string locale)
{
    return getCanonicalLocales(new Array() {
            Add(new string(locale));
});
    }
    //////////////////////////////

    public static class Locale extends Dict
{



    override
        public string ToString()
{
    return null;
}

override
        public string toLocaleString(string locales, object options)
{
    return null;
}

override
        public object invoke(params object[] objs)
{
    return null;
}

public static class Options extends Dict
{

            public Options(string locale, Dict options)
{
    _locale = locale;
    for (java.util.Map.Entry<string, object> entry:options.entrySet()){
    object value = entry.getValue();
    switch (entry.getKey())
    {
        case "localeMatcher": _localeMatcher = ((string)value).THIS; break;
        case "usage": _usage = ((string)value).THIS; break;
        case "sensitivity": _sensitivity = ((string)value).THIS; break;
        case "ignorePunctuation": _ignorePunctuation = ((JsBoolean)value).THIS; break;
        case "numeric": _numeric = ((string)value).THIS; break;
        case "caseFirst": _caseFirst = ((string)value).THIS; break;
        default: break;
    }
}
            }

            private string _localeMatcher = "best fit";

public string getLocaleMatcher()
{
    return _localeMatcher;
}

private string _usage = "sort";

public string getUsage()
{
    return _usage;
}

private string _sensitivity = "variant";

public string getSensitivity()
{
    return _sensitivity;
}

private bool _ignorePunctuation;

public bool getIgnorePunctuation()
{
    return _ignorePunctuation;
}

private string _numeric = "false";

public string getNumeric()
{
    return _numeric;
}

private string _caseFirst = "false";

public string getCaseFirst()
{
    return _caseFirst;
}
private string _locale;
public string getLocale()
{
    return _locale;
}
private string _collation = "default";
public string getCollation()
{
    return _collation;
}

override
            public object get(object key)
{
    return null;
}

override
            public void set(object key, object value)
{

}

override
            public string ToString()
{
    return null;
}

override
            public string toLocaleString(string locales, object options)
{
    return null;
}

override
            public object invoke(params object[] objs)
{
    return null;
}
        }
        //////////////////////////
        public Locale(string tag, Dict options)
{
    string[] data = tag.split("-");
    for (int i = 0; i < data.length; i++)
    {
        string dat = data[i];
        switch (i)
        {
            case 0:
                _language = dat;
                break;
            case 1:
                _script = dat;
                break;
            case 2:
                _region = dat;
                break;
            case 3:
                _calendar = dat;
                break;
            case 4:
                break;
            case 5:
                _country = dat;
                break;
            case 6:
                //  _collation=dat;
                break;
            case 7:
                _hourCycle = dat;
                break;
            default:
                throw new RangeError(new string(dat));
        }
    }
    for (java.util.Map.Entry<string, object> entry : options.entrySet()) {
    object value = entry.getValue();
    switch (entry.getKey().trim())
    {
        case "script":
            _script = value.ToString(); break;
        case "region":
            _region = value.ToString(); break;
        case "hourCycle":
            _hourCycle = value.ToString(); break;
        case "calendar":
            _calendar = value.ToString(); break;
        default:
            throw new RangeError(new string(entry.getKey()));
    }
}
_THIS = new java.util.Locale(string.Format("%s-%s", getLanguage(), getRegion()));
        }

        public Locale(string tag)
{
    this(tag, new Dict());
}
/////////////////////
private string _country;
public string getCountry()
{
    return _country;
}
private string _language;
public string getLanguage()
{
    return _language;
}
public string getBaseName()
{
    return string.Format("%s-%s-%s", getLanguage(), getScript(), getRegion());
}

private string _script;
public string getScript()
{
    return _script;
}
private string _region;
public string getRegion()
{
    return _region;
}
private string _hourCycle;
public string getHourCycle()
{
    return _hourCycle;
}
private string _calendar;
public string getCalendar()
{
    return _calendar;
}
///////////
private java.util.Locale _THIS;


    }

    //////////////////////////////
    public static class Collator extends Dict
{

        //////////////////////////
private Locale _locale;
private Locale.Options _options;

public Collator(string locales, Dict options)
{
    _locale = new Locale(locales);
    _options = new Locale.Options(locales, options);
}

public Collator(string locales)
{
    this(locales, new Dict());
}

public Collator()
{
    this(java.util.Locale.getDefault().ToString());
}

////////////////////////////////////////
public int compare(string string1, string string2)
{
    java.text.Collator myCollator = java.text.Collator.getInstance(_locale._THIS);
    return myCollator.compare(string1, string2);
}

public Locale.Options resolvedOptions()
{
    return _options;
}
public static Array supportedLocalesOf(Array locales, Dict options)
{
    Array result = new Array();
    for (object locale : locales) {
    if (allLocale.contains(locale.ToString().toUpperCase()))
    {
        result.Add(locale);
    }
}
return result;
        }

        public static Array supportedLocalesOf(Array locales)
{
    return supportedLocalesOf(locales, new Dict());
}
public static Array supportedLocalesOf(object locales, Dict options)
{
    return supportedLocalesOf(new Array() { { Add(locales);
},options);
        }

        public static Array supportedLocalesOf(object locales)
{
    return supportedLocalesOf(locales, new Dict());
}

override
        public object get(object key)
{
    return null;
}

override
        public void set(object key, object value)
{

}

override
        public string ToString()
{
    return null;
}

override
        public string toLocaleString(string locales, object options)
{
    return null;
}

override
        public object invoke(params object[] objs)
{
    return null;
}
    }

    public static class DateTimeFormat extends Dict
{

    override
        public string toLocaleString(string locales, object options)
{
    return null;
}

override
        public object invoke(params object[] objs)
{
    return null;
}

public static class Options extends Dict
{

            public Options(Dict options)
{
    for (java.util.Map.Entry<string, object> entry:options.entrySet()) {
    object value = entry.getValue();
    switch (entry.getKey())
    {
        case "dateStyle":
            _dateStyle = ((string)value).THIS;
            break;
        case "timeStyle":
            _timeStyle = ((string)value).THIS;
            break;
        case "fractionalSecondDigits":
            _fractionalSecondDigits = ((JsNumber)value).THIS.floatValue();
            break;
        case "calendar":
            _calendar = ((string)value).THIS;
            break;
        case "dayPeriod":
            _dayPeriod = ((string)value).THIS;
            break;
        case "numberingSystem":
            _numberingSystem = ((string)value).THIS;
            break;
        case "localeMatcher":
            _localeMatcher = ((string)value).THIS;
            break;
        case "timeZone":
            _timeZone = ((string)value).THIS;
            break;
        case "hour12":
            _hour12 = ((JsBoolean)value).THIS;
            break;
        case "hourCycle":
            _hourCycle = ((string)value).THIS;
            break;
        case "formatMatcher":
            _formatMatcher = ((string)value).THIS;
            break;
        case "weekday":
            _weekday = ((string)value).THIS;
            break;
        case "era":
            _era = ((string)value).THIS;
            break;
        case "year":
            _year = ((string)value).THIS;
            break;
        case "hour":
            _hour = ((string)value).THIS;
            break;
        case "minute":
            _minute = ((string)value).THIS;
            break;
        case "second":
            _second = ((string)value).THIS;
            break;
        case "timeZoneName":
            _timeZoneName = ((string)value).THIS;
            break;
        default:
            break;
    }
}
            }
            private string _dateStyle;

public string getDateStyle()
{
    return _dateStyle;
}

private string _timeStyle;

public string getTimeStyle()
{
    return _timeStyle;
}

private double _fractionalSecondDigits = 0;

public double getFractionalSecondDigits()
{
    return _fractionalSecondDigits;
}

private string _calendar;

public string getCalendar()
{
    return _calendar;
}


private string _dayPeriod = "best fit";

public string getDayPeriod()
{
    return _dayPeriod;
}

private string _numberingSystem;

public string getNumberingSystem()
{
    return _numberingSystem;
}
private string _localeMatcher = "best fit";

public string getLocaleMatcher()
{
    return _localeMatcher;
}

private string _timeZone;

public string getTimeZone()
{
    return _timeZone;
}

private bool _hour12;

public bool getHour12()
{
    return _hour12;
}


private string _hourCycle;

public string getHourCycle()
{
    return _hourCycle;
}

private string _formatMatcher = "best fit";

public string getFormatMatcher()
{
    return _formatMatcher;
}

private string _weekday;

public string getWeekday()
{
    return _weekday;
}

private string _era;

public string getEra()
{
    return _era;
}

private string _year;

public string getYear()
{
    return _year;
}

private string _month;

public string getMonth()
{
    return _month;
}

private string _day;

public string getDay()
{
    return _day;
}

private string _hour;

public string getHour()
{
    return _hour;
}

private string _minute;

public string getMinute()
{
    return _minute;
}

private string _second;

public string getSecond()
{
    return _second;
}

private string _timeZoneName;

public string getTimeZoneName()
{
    return _timeZoneName;
}

override
            public object get(object key)
{
    return null;
}

override
            public void set(object key, object value)
{

}

override
            public string ToString()
{
    return null;
}

override
            public string toLocaleString(string locales, object options)
{
    return null;
}

override
            public object invoke(params object[] objs)
{
    return null;
}
        }
        ///////////////////////
        private Array _locales;
private Options _options;

public DateTimeFormat(Array locales, Dict options)
{
    _locales = locales;
    _options = new Options(options);
}

public DateTimeFormat(Array locales)
{
    this(locales, new Dict());
}

public DateTimeFormat()
{
    this(java.util.Locale.getDefault().ToString());
}

public DateTimeFormat(string locales, Dict options)
{
    this(new Array() {
                Add(new string(locales));
}, new Dict());
        }

        private DateTimeFormat(string locales)
{
    this(locales, new Dict());
}

////////////////////////////////////////
public string Format(Date date)
{
    return date.ToString();
}

public string formatRange(Date startDate, Date endDate)
{
    return string.Format("%s - %s", startDate.ToString(), endDate.ToString());
}

public Array formatToParts(Date date)
{
    return new Array();
}

public DateTimeFormat.Options resolvedOptions()
{
    return _options;
}

public Array supportedLocalesOf(Array locales, Dict options)
{
    return new Array();
}

public Array supportedLocalesOf(Array locales)
{
    return supportedLocalesOf(locales, new Dict());
}
public Array supportedLocalesOf(object locales, Dict options)
{
    return supportedLocalesOf(new Array() { { Add(locales);
},options);
        }

        public Array supportedLocalesOf(string locales)
{
    return supportedLocalesOf(locales);
}
    }

    public static class ListFormat extends Dict
{
    override
        public object get(object key)
{
    return null;
}

override
        public void set(object key, object value)
{

}

override
        public string ToString()
{
    return null;
}

override
        public string toLocaleString(string locales, object options)
{
    return null;
}

override
        public object invoke(params object[] objs)
{
    return null;
}

public static class Options extends Dict
{
    private string _localeMatcher;

public string getLocaleMatcher()
{
    return _localeMatcher;
}

private string _type;

public string getType()
{
    return _type;
}

private string _style;

public string getStyle()
{
    return _style;
}

public Options(Dict options)
{
    for (java.util.Map.Entry<string, object> entry : options.entrySet()) {
    object value = entry.getValue();
    switch (entry.getKey())
    {
        case "localeMatcher":
            _localeMatcher = ((string)value).THIS;
            break;
        case "type":
            _type = ((string)value).THIS;
            break;
        case "style":
            _style = ((string)value).THIS;
            break;
        default:
            break;
    }
}
    }

            override
            public object get(object key)
{
    return null;
}

override
            public void set(object key, object value)
{

}

override
            public string ToString()
{
    return null;
}

override
            public string toLocaleString(string locales, object options)
{
    return null;
}

override
            public object invoke(params object[] objs)
{
    return null;
}
        }
        ///////////////////
        Array _locales;
private Options _options;
public ListFormat(Array locales, Dict options)
{
    _locales = locales;
    _options = new Options(options);
}

public ListFormat(Array locales)
{
    this(locales, new Dict());
}
private ListFormat(string locale, Dict options)
{
    this(new Array() {
                Add(new string(locale));
}, options);
        }

        public ListFormat(string locales)
{
    this(locales, new Dict());
}
public ListFormat()
{
    this(java.util.Locale.getDefault().ToString());
}
////////////////////////////////////////
public Array supportedLocalesOf(string locales, Dict options)
{
    return new Array();
}

public Array supportedLocalesOf(string locales)
{
    return supportedLocalesOf(locales, new Dict());
}
public Array supportedLocalesOf()
{
    return supportedLocalesOf(java.util.Locale.getDefault().ToString());
}
public string Format(Array list)
{
    return "";
}

public string Format()
{
    return Format(new Array());
}
public string Format(string list)
{
    return Format(Onekit_JS.string2Array(list));
}
public Array formatToParts(Array list)
{
    return new Array();
}

public Options resolvedOptions()
{
    return _options;
}

    }

    public static class NumberFormat extends Dict
{
    override
        public object get(object key)
{
    return null;
}

override
        public void set(object key, object value)
{

}

override
        public string ToString()
{
    return null;
}

override
        public string toLocaleString(string locales, object options)
{
    return null;
}

override
        public object invoke(params object[] objs)
{
    return null;
}

public static class Options extends Dict
{

        public Options(Dict options)
{
    for (Map.Entry<string, object> entry : options.entrySet()) {
    object value = entry.getValue();
    switch (entry.getKey().ToString())
    {
        case "localeMatcher":
            _localeMatcher = ((string)value).THIS;
            break;
        case "style":
            _style = ((string)value).THIS;
            break;

        case "numberingSystem":
            _numberingSystem = ((string)value).THIS;
            break;

        case "unit":
            _unit = ((string)value).THIS;
            break;

        case "unitDisplay":
            _unitDisplay = ((string)value).THIS;
            break;

        case "currency":
            _currency = ((string)value).THIS;
            break;

        case "currencyDisplay":
            _currencyDisplay = ((string)value).THIS;
            break;
        case "useGrouping":
            _useGrouping = ((JsBoolean)value).THIS;
            break;
        case "minimumIntegerDigits":
            _minimumIntegerDigits = ((JsNumber)value).THIS.longValue();
            break;
        case "minimumFractionDigits":
            _minimumFractionDigits = ((JsNumber)value).THIS.longValue();
        case "maximumFractionDigits":
            _maximumFractionDigits = ((JsNumber)value).THIS.longValue();
            break;
        case "minimumSignificantDigits":
            _minimumSignificantDigits = ((JsNumber)value).THIS.longValue();
            break;
        case "maximumSignificantDigits":
            _maximumSignificantDigits = ((JsNumber)value).THIS.longValue();
            break;
        case "notation":
            _notation = ((string)value).THIS;
            break;
        default:
            break;
    }
}
        }
            private string _localeMatcher = "best fit";
public string getLocaleMatcher()
{
    return _localeMatcher;
}
private string _style = "decimal";
public string getStyle()
{
    return _style;
}
private string _numberingSystem;
public string getNumberingSystem()
{
    return _numberingSystem;
}
private string _unit;
public string getUnit()
{
    return _unit;
}
private string _unitDisplay = "symbol";
public string getUnitDisplay()
{
    return _unitDisplay;
}
private string _currency;
public string getCurrency()
{
    return _currency;
}
private string _currencyDisplay;
public string getCurrencyDisplay()
{
    return _currencyDisplay;
}
private bool _useGrouping = true;
public bool getUseGrouping()
{
    return _useGrouping;
}
private long _minimumIntegerDigits = 1l;
public long getMinimumIntegerDigits()
{
    return _minimumIntegerDigits;
}
private long _minimumFractionDigits = 0l;
public long getMinimumFractionDigits()
{
    return _minimumFractionDigits;
}
private long _maximumFractionDigits = 0l;
public long getMaximumFractionDigits()
{
    return _maximumFractionDigits;
}
private long _minimumSignificantDigits = 1l;
public long getMinimumSignificantDigits()
{
    return _minimumSignificantDigits;
}
private long _maximumSignificantDigits = 21l;
public long getMaximumSignificantDigits()
{
    return _maximumSignificantDigits;
}
private string _notation = "standard";
public string getNotation()
{
    return _notation;
}

override
            public object get(object key)
{
    return null;
}

override
            public void set(object key, object value)
{

}

override
            public string ToString()
{
    return null;
}

override
            public string toLocaleString(string locales, object options)
{
    return null;
}

override
            public object invoke(params object[] objs)
{
    return null;
}
        }
            //////////////////////////
        private Array _locales;
private Options _options;
private NumberFormat(object locales, object options)
{
    _locales = (Array)locales;
    _options = new Options((Dict)options);
}

public NumberFormat(object locales)
{
    this(locales, new Dict());
}
public NumberFormat()
{
    this(java.util.Locale.getDefault().ToString());
}
public NumberFormat(string locales, Dict options)
{
    this(new Array() { { Add(new string(locales));
},options);
        }

        public NumberFormat(string locales)
{
    this(locales, new Dict());
}
////////////////////////////////////////
public string Format(object number)
{
    return "";
}

public Array formatToParts(object number)
{
    return new Array();
}

public Options resolvedOptions()
{
    return _options;
}

public Array supportedLocalesOf(string locales, Dict options)
{
    return new Array();
}

public Array supportedLocalesOf(string locales)
{
    return supportedLocalesOf(locales, new Dict());
}
    }

    public static class PluraRules extends Dict
{
    override
        public object get(object key)
{
    return null;
}

override
        public void set(object key, object value)
{

}

override
        public string ToString()
{
    return null;
}

override
        public string toLocaleString(string locales, object options)
{
    return null;
}

override
        public object invoke(params object[] objs)
{
    return null;
}

public static class Options
{

}
private string _locale;
private Options _options;
public PluraRules(string locale)
{
    _locale = locale;
    _options = new Options();
}
public PluraRules()
{
    this(java.util.Locale.getDefault().ToString());
}
public Options resolvedOptions()
{
    return _options;
}

public string select(object number)
{
    return "";
}

public Array supportedLocalesOf(string locales, Dict options)
{
    return new Array();
}

public Array supportedLocalesOf(string locales)
{
    return supportedLocalesOf(locales, new Dict());
}


    }

    public static class RelvativeTimeFormat extends Dict
{
    override
        public object get(object key)
{
    return null;
}

override
        public void set(object key, object value)
{

}

override
        public string ToString()
{
    return null;
}

override
        public string toLocaleString(string locales, object options)
{
    return null;
}

override
        public object invoke(params object[] objs)
{
    return null;
}

public static class Options 
{

    override
            public object get(string key)
{
    return null;
}

override
            public object get(object key)
{
    return null;
}

override
            public void set(string key, object value)
{

}

override
            public void set(object key, object value)
{

}

override
            public string ToString()
{
    return null;
}

override
            public string toLocaleString(string locales, object options)
{
    return null;
}

override
            public object invoke(params object[] objs)
{
    return null;
}
        }
     /////////////////
       private string _locales;
private Options _options;
public RelvativeTimeFormat(string locales, Dict options)
{
    _locales = locales;
    _options = new Options();
}
public RelvativeTimeFormat(string locales)
{
    this(locales, new Dict());
}
public string Format(int value, string unit)
{
    return "";
}


public Options resolvedOptions()
{
    return _options;
}

public Array supportedLocalesOf(string locales, Dict options)
{
    return new Array();
}

public Array supportedLocalesOf(string locales)
{
    return supportedLocalesOf(locales, new Dict());
}

    }
    }
}
