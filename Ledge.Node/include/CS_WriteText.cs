#r "include\Ledge.Net.dll"
#r "include\LogitechWrapper.dll"

using System;
using Ledge.Net;
using LogitechWrapper;
using System.Threading.Tasks;
		
public class Startup
{
	public async Task<object> Invoke(object[] input)
	{
		int line = int.Parse(input[0].ToString());
		string text = input[1].ToString();
		Ledge.Net.Ledge.Lcd.WriteText(line, text);
		return true;
	}
}