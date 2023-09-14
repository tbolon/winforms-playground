using System.Reflection;

[assembly: AssemblyTitle("My Control Library 2")]
[assembly: AssemblyCompany("ACME")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.1")]
[assembly: AssemblyInformationalVersion("1.0.2")]

#if NETCOREAPP
[assembly: System.Runtime.Versioning.TargetPlatform("Windows7.0")]
[assembly: System.Runtime.Versioning.SupportedOSPlatform("Windows7.0")]
#endif