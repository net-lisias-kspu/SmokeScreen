﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("SmokeScreen /L Unofficial")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("L Aerospace/KSP Divisoin")]
[assembly: AssemblyProduct("SmokeScreen")]
[assembly: AssemblyCopyright("© 2014-2020 Sarbian, © 2021 LisiasT")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM

[assembly: Guid("6879e39e-17f5-44d4-9d52-a25bd0851b7f")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(SmokeScreen.Version.Number)]
[assembly: AssemblyFileVersion(SmokeScreen.Version.Number)]
[assembly: KSPAssembly("SmokeScreen", SmokeScreen.Version.major, SmokeScreen.Version.minor)]
[assembly: KSPAssemblyDependency("KSPe", 2, 2)]
[assembly: KSPAssemblyDependency("KSPe.UI", 2, 2)]
