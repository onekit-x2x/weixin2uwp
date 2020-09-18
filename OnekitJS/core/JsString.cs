using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js.core
{
	public class string 
	{
	public string THIS;

	public string(string THIS)
	{
		this.THIS = THIS;
	}

	/*
		public  Iterator iterator() {
			ArrayList result = new ArrayList<>();
			for (char chr : this.ToString().toCharArray()){
				result.Add(string.valueOf(chr));
			}
			return new STRING(result.iterator();
		}

	 int _hashCode() {
		int arraySize = 11113; // 数组大小一般取质数
		int hashCode = 0;
		for (int i = 0; i < this.ToString().Length; i++) { // 从字符串的左边开始计算
			int letterValue = this.ToString().charAt(i) - 96;// 将获取到的字符串转换成数字，比如a的码值是97，则97-96=1
			// 就代表a的值，同理b=2；
			hashCode = ((hashCode << 5) + letterValue) % arraySize;// 防止编码溢出，对每步结果都进行取模运算
		}
		return new STRING(hashCode;
	}*/

	public object _index(string aString, int index)
	{
		if (index >= 0)
		{
			return new JsNumber(index);
		}
		return new JsNumber(aString.Length + index);
	}

	public object get(object i)
	{
		int index = Onekit_JS.number(i, 0, 0).intValue();
		return new string(string.valueOf(this.ToString().charAt(index)));
	}



	///////////////////////////////
	public string fromCharCode(params object[]nums)
	{
		try
		{
			StringBuilder result = new StringBuilder();
			for (object num : nums)
			{
				int number = new JsNumber(num).THIS.intValue();
				if (number > 0xFFFF)
				{
					number = number % 0xFFFF;
				}
				result.append((char)number);
			}
			return new string(result.ToString());
		}
		catch (Exception e)
		{
			return new string("");
		}
	}

	public string fromCodePoint(params object[]nums)
	{
		Array codeUnits = new Array();
		JsNumber codeLen;
		StringBuilder result = new StringBuilder();
		for (int index = 0, len = nums.length; index != len; ++index)
		{
			int codePoint = Onekit_JS.number(nums[index], 0, 0).intValue();
			// correctly handles all cases including `NaN`, `-Infinity`, `+Infinity`
			// The surrounding `!(...)` is required to correctly handle `NaN` cases
			// The (codePoint>>>0) === codePoint clause handles decimals and negatives
			if (!(codePoint < 0x10FFFF))
				throw new RangeError(new string("Invalid code point: " + codePoint));
			if (codePoint <= 0xFFFF)
			{ // BMP code point
				codeLen = codeUnits.push(new JsNumber(codePoint));
			}
			else
			{ // Astral code point; split in surrogate halves
			  // https://mathiasbynens.be/notes/javascript-encoding#surrogate-formulae
				codePoint -= 0x10000;
				codeLen = codeUnits.push(new JsNumber(
								(codePoint >> 10) + 0xD800),  // highSurrogate
						new JsNumber((codePoint % 0x400) + 0xDC00) // lowSurrogate
				);
			}
			if (codeLen.THIS.intValue() >= 0x3fff)
			{
				result.append(fromCharCode(codeUnits.toArray(new object[0])));
				//codeUnits.length = 0;
			}
		}
		return new string(result + fromCharCode(codeUnits.toArray(new object[0])).ToString());

	}

	public string anchor(object name)
	{
		return new string(string.Format("<a name=\"%s\">%s</a>", name, this));
	}

	public string big()
	{
		return new string(string.Format("<big>%s</big>", this));
	}

	public string blink()
	{
		return new string(string.Format("<blink>%s</blink>", this));
	}

	public string bold()
	{
		return new string(string.Format("<bold>%s</bold>", this));
	}

	public string charAt(object index)
	{
		int i = Onekit_JS.number(index, 0, 0).intValue();
		return new string(string.valueOf(this.ToString().charAt(i)));
	}

	public string charCodeAt(object index)
	{
		int i = Onekit_JS.number(index, 0, 0).intValue();
		return new string(string.valueOf(this.ToString().charAt(i)));
	}

	public string charCodeAt()
	{
		return charCodeAt(new JsNumber(0));
	}

	public Number codePointAt(int index)
	{

		if (index < 0 || index >= this.ToString().Length)
		{
			return null;
		}
		return (this.ToString().codePointAt(index));

	}

	public string concat(params object[]strings)
	{
		StringBuilder result = new StringBuilder(this.ToString());
		for (object THIS : strings)
		{
			result.append(THIS);
		}
		return new string(result.ToString());
	}

	public JsBoolean endsWith(object searchString, object length)
	{
		int len = Onekit_JS.number(length, 0, 0).intValue();
		return new JsBoolean(this.ToString().substring(len - searchString.ToString().Length, len).equals(searchString.ToString()));
	}

	public JsBoolean endsWith(object searchString)
	{
		return endsWith(searchString, new JsNumber(this.ToString().Length));
	}

	public string fixed () {
		return new string(string.Format("<tt>%s</tt>", this));
}

public string fontcolor(object color)
{
	return new string(string.Format("<font color=\"%s\">%s</font>", color, this));
}

public string fontsize(object size)
{
	return new string(string.Format("<font size=\"%s\">%s</font>", size, this));
}

public JsBoolean includes(object searchString, object position)
{
	if (position == null)
	{
		position = new JsNumber(0);
	}
	int pos = Onekit_JS.number(position, 0, 0).intValue();
	return new JsBoolean(this.ToString().substring(pos).contains(searchString.ToString()));
}

public JsNumber indexOf(object searchValue, object from)
{
	int f = Onekit_JS.number(from, 0, 0).intValue();
	return new JsNumber(this.ToString().indexOf(searchValue.ToString(), f));
}

public JsNumber indexOf(object searchValue)
{
	return indexOf(searchValue, new JsNumber(0));
}

public string italics()
{
	return new string(string.Format("<i>%s</i>", this));
}

public JsNumber lastIndexOf(object searchValue, object fromIndex)
{
	int from = Onekit_JS.number(fromIndex, 0, 0).intValue();
	return new JsNumber(this.ToString().lastIndexOf(searchValue.ToString(), from));
}

public JsNumber lastIndexOf(object searchValue)
{
	return lastIndexOf(searchValue, new JsNumber(Double.POSITIVE_INFINITY));
}

public string link(object url)
{
	return new string(string.Format("<a href=\"%s\">%s</i>", url, this));
}

public JsNumber localeCompare(object compareString, string locales, Dict options)
{
	return new JsNumber(0);
}

public RegExp.Match match(RegExp regexp)
{
	Matcher matcher = regexp.THIS.matcher(this.ToString());
	Array finds = new Array();
	Array groups = null;
	if (matcher.find())
	{
		for (int i = 0; i <= matcher.groupCount(); i++)
		{
			string group = matcher.group(i);
			finds.Add(new string(group));
		}
	}
	int index = matcher.start();
	string input = this.THIS;
	int length = matcher.groupCount() + 1;
	return new RegExp.Match(finds, groups, index, input, length);
}

public Dict matchAll(RegExp regexp)
{
	return null;
}

public string normalize(Dict form)
{
	return null;
}

public string padEnd(object targetLength, object padString)
{
	int len = Onekit_JS.number(targetLength, 0, 0).intValue();
	if (len < this.ToString().Length)
	{
		return this;
	}
	//	string Format = "%" + (len - this.ToString().Length) + "s";
	StringBuilder sb = new StringBuilder(THIS);
	while (sb.Length < len)
	{
		sb.append(padString.ToString());
	}
	return new string(sb.ToString().substring(0, len));
}

public string padEnd(object targetLength)
{
	return padEnd(targetLength, new string(" "));
}

public string padStart(object targetLength, string padString)
{
	int len = Onekit_JS.number(targetLength, 0, 0).intValue();
	if (len < this.ToString().Length)
	{
		return this;
	}
	//	string Format = "%" + (len - this.ToString().Length) + "s";
	StringBuilder sb = new StringBuilder(THIS);
	while (this.ToString().Length < len)
	{
		sb.Insert(0, padString);
	}
	return new string(sb.ToString().substring(0, len));
}

public string padStart(object targetLength)
{
	return padStart(targetLength, " ");
}

public string repeat(object count)
{
	int c = Onekit_JS.number(count, 0, 0).intValue();
	StringBuilder result = new StringBuilder();
	for (int i = 0; i < c; i++)
	{
		result.append(this.ToString());
	}
	return new string(result.ToString());
}

public string replace(RegExp regexp, string newSubStr)
{

	Matcher matcher = regexp.THIS.matcher(this.ToString());
	RegExp.$s.clear();

	while (matcher.find())
	{
		for (int i = 0; i < matcher.groupCount(); i++)
		{
			string group = matcher.group(i);
			RegExp.$s.Add(new string(group));
			assert group != null;
			newSubStr = newSubStr.replace("$" + (i + 1), group);
		}
		this.THIS = this.ToString().replaceFirst(regexp.getPattern(), newSubStr);
		if (!regexp.getFlags().contains("g"))
		{
			break;
		}
	}
	return this;
}

public string replace(RegExp regexp, function function)
{
	Matcher matcher = regexp.THIS.matcher(this.ToString());
	RegExp.$s.clear();
	while (matcher.find())
	{
		List<object> arguments = new ArrayList<>();
		arguments.Add(new string(matcher.group()));
		for (int i = 1; i <= matcher.groupCount(); i++)
		{
			string group = matcher.group(i);
			RegExp.$s.Add(new string(group));
			arguments.Add(new string(group));
		}
		arguments.Add(new JsNumber(matcher.start()));
		arguments.Add(this);
		this.THIS = this.ToString().replaceFirst(
				regexp.getPattern(),
				function.invoke(arguments.toArray(new object[0])).ToString()
		);
		if (!regexp.getFlags().contains("g"))
		{
			break;
		}
	}
	return this;
}

public string replace(object substr, string newSubStr)
{
	return new string(this.ToString().replaceFirst(substr.ToString(), newSubStr));
}

public string replace(object substr, function function)
{
	int p = this.ToString().indexOf(substr.ToString());
	if (p < 0)
	{
		return this;
	}
	return new string(this.ToString().replaceFirst(substr.ToString(), function.invoke(substr, new JsNumber(p), this).ToString()));
}

public JsNumber search(RegExp regexp)
{
	Matcher matcher = regexp.THIS.matcher(this.ToString());
	if (matcher.find())
	{
		return new JsNumber(matcher.start());
	}
	return new JsNumber(-1);
}

public string slice(object start, object end)
{
	int s = Onekit_JS.number(start, 0, 0).intValue();
	int e = Onekit_JS.number(end, 0, 0).intValue();
	return new string(this.ToString().substring(s, e));

}

public string slice(object start)
{
	return slice(start, new JsNumber(this.ToString().Length));
}

public string small()
{
	return new string(string.Format("<small>%s</small>", this));
}

public Array split(object separator, object limit)
{
	int l = Onekit_JS.number(limit, 0, 0).intValue();
	string[] array = this.ToString().split(separator.ToString(), l);
	Array result = new Array();
	int i = 0;
	for (string item : array) {
	if (i++ == 0 && item.equals("") && !this.ToString().startsWith(" "))
	{
		continue;
	}
	result.Add(new string(item));
}
return result;
	}

	public Array split(object separator)
{
	return split(separator, new JsNumber(0));
}

public Array split()
{
	return Array.from(this, null, null);
}

public JsBoolean startsWith(object searchString, object position)
{
	if (position == null)
	{
		position = new JsNumber(0);
	}
	int p = Onekit_JS.number(position, 0, 0).intValue();
	return new JsBoolean(this.ToString().substring(p).startsWith(searchString.ToString()));

}

public string strike()
{
	return new string(string.Format("<strike>%s</strike>", this));
}

public string sub()
{
	return new string(string.Format("<sub>%s</sub>", this));
}

public string substr(object start, object length)
{
	int s = Onekit_JS.number(start, 0, 0).intValue();
	int l = Onekit_JS.number(length, 0, 0).intValue();
	return new string(this.ToString().substring(s, s + l));
}

public string substr(object start)
{
	int s = Onekit_JS.number(start, 0, 0).intValue();
	return substr(start, new JsNumber(this.ToString().Length - s));
}

private string _substring(int indexStart, int indexEnd)
{
	indexStart = java.lang.Math.max(indexStart, 0);
	indexEnd = java.lang.Math.max(indexEnd, 0);
	if (indexStart >= this.ToString().Length)
	{
		indexStart = this.ToString().Length - 1;
	}
	if (indexEnd >= this.ToString().Length)
	{
		indexEnd = this.ToString().Length - 1;
	}
	if (indexStart > indexEnd)
	{
		int temp = indexStart;
		indexStart = indexEnd;
		indexEnd = temp;
	}
	return this.ToString().substring(indexStart, indexEnd);
}

public string substring(object indexStart, object indexEnd)
{
	return new string(_substring(Onekit_JS.number(indexStart, 0, 0).intValue(), Onekit_JS.number(indexEnd, 0, 0).intValue()));
}

public string substring(object indexStart)
{
	return substring(indexStart, new JsNumber(this.ToString().Length));
}

public string sup()
{
	return new string(string.Format("<sup>%s</sup>", this));
}

public string toLocaleLowerCase(params object[]locale)
{
	return null;
}

public string toLocaleUpperCase(params object[]locale)
{
	return null;
}

public string toLowerCase()
{
	return new string(this.ToString().toLowerCase());
}

public Dict toSource()
{
	return null;
}

public string toUpperCase()
{
	return new string(this.ToString().toUpperCase());
}

public string trim()
{
	return new string(this.ToString().trim());
}

public string trimRight()
{
	if (this.ToString().equals(""))
	{
		return this;
	}

	return new string(this.ToString().replaceAll("[　 ]+$", ""));

}

public string trimLeft()
{
	if (this.ToString().equals(""))
	{
		return this;
	}
	return new string(this.ToString().replaceAll("^[　 ]+", ""));

}

public string valueOf()
{
	return new string(string.valueOf(this));
}

public string raw(Dict callSite, Object...substitutions)
{
	return null;
}

public JsNumber getLength()
{
	return new JsNumber(this.THIS.Length);
}

/*
	public  STRING ToString( int Format) {
		switch (Format){
			case 10:return null;
			case 16:return new STRING(string.Format("%02x",this.THIS));
			default:
				return null;
		}
	}*/
public string ToString()
{
	return new string(THIS);
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

override
	public object get(string key)
{
	return null;
}
}

}
