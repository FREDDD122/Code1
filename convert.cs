using System;
using System.Collections.Generic;
using System.Text;
class FengGameManagerMKII
{
	
	string ConvertToChat(string text)
	{
		if (text.Contains("]"))
		{
			text = text.Replace("]", ">");
		}
		bool flag = false;
		while (true)
		{
			if (!text.Contains("[") || flag)
			{
				if (flag)
				{
					return string.Empty;
				}
				return text;
			}
			int index = text.IndexOf("[");
			if (text.Length < (index + 7))
			{
				flag = true;
			}
			else
			{
				string str = text.Substring(index + 1, 6);
				text = text.Remove(index, 7).Insert(index, "<color=#" + str);
				int length = text.Length;
				if (text.Contains("["))
				{
					length = text.IndexOf("[");
				}
				text = text.Insert(length, "</color>");
			}
		}
	}
}
