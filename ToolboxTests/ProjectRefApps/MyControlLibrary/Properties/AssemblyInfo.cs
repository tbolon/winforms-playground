using System.Reflection;

[assembly: AssemblyTitle("My Control Library")]
[assembly: AssemblyCompany("ACME")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.1")]
[assembly: AssemblyInformationalVersion("1.0.2")]

#if NETCOREAPP
[assembly: System.Runtime.Versioning.TargetPlatform("Windows7.0")]
[assembly: System.Runtime.Versioning.SupportedOSPlatform("Windows7.0")]
#endif

/*
 * 
 * 

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: TargetFramework(".NETCoreApp,Version=v7.0", FrameworkDisplayName = ".NET 7.0")]
[assembly: AssemblyCompany("MyControlLibrary")]
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyFileVersion("23.914.1757.0")]
[assembly: AssemblyInformationalVersion("23.0914.1757+b1b4e75cecc39b861de5043f4f5bb8ccbb45fde0")]
[assembly: AssemblyProduct("MyControlLibrary")]
[assembly: AssemblyTitle("MyControlLibrary")]
[assembly: TargetPlatform("Windows7.0")]
[assembly: SupportedOSPlatform("Windows7.0")]
[assembly: AssemblyVersion("23.914.1757.0")]
[module: System.Runtime.CompilerServices.RefSafetyRules(11)]


[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyTitle("My Control Library")]
[assembly: TargetFramework(".NETCoreApp,Version=v7.0", FrameworkDisplayName = ".NET 7.0")]
[assembly: AssemblyVersion("0.0.0.0")]
[module: RefSafetyRules(11)]


*/