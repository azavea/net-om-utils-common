﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Azavea.Open.Common")]
[assembly: AssemblyDescription("A set of common C# utility classes. Part of the Oatmeal Utilities library.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Azavea")]
[assembly: AssemblyProduct("Azavea.Open.Common")]
[assembly: AssemblyCopyright("Copyright (©) Azavea 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b07cd7bb-dd80-4be6-b48b-03f3313e779c")]

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
[assembly: AssemblyVersion("2.1.10.*")]
[assembly: AssemblyFileVersion("2.1.10")]
// Used for nuget packaging
[assembly: AssemblyInformationalVersion("2.1.10")]
