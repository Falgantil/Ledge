#r "include\Ledge.Net.dll"
#r "include\LogitechWrapper.dll"

using System;
using Ledge.Net;
using LogitechWrapper;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

public class Startup
{
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	static extern bool SetDllDirectory(string lpPathName);
	
	public async Task<object> Invoke(object input)
	{
		SetDllDirectory("include");
		Ledge.Net.Ledge.Lcd = new Lcd(input.ToString(), LcdScreenType.Mono);
		
		return true;
	}
}