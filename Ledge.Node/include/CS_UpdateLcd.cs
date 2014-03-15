#r "include\Ledge.Net.dll"
#r "include\LogitechWrapper.dll"

using System;
using Ledge.Net;
using LogitechWrapper;
using System.Threading.Tasks;
		
public class Startup
{
	public async Task<object> Invoke(object input)
	{
		Ledge.Net.Ledge.Lcd.UpdateLcd();
		return true;
	}
}