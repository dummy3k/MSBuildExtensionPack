//-----------------------------------------------------------------------
// <copyright file="CommonAssemblyInfo.cs">(c) http://www.codeplex.com/MSBuildExtensionPack. This source is subject to the Microsoft Permissive License. See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx. All other rights reserved.</copyright>
//-----------------------------------------------------------------------
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Permissions;

[assembly:AssemblyVersion("3.5.0.0")]
[assembly: AssemblyFileVersion("3.5.0.0")]
[assembly:PermissionSet(SecurityAction.RequestMinimum, Name = "FullTrust")]
[assembly:PermissionSet(SecurityAction.RequestOptional, Name = "Nothing")]
[assembly: AssemblyCompany("http://www.codeplex.com/MSBuildExtensionPack")]
[assembly: AssemblyCopyright("Copyright � 2008 http://www.codeplex.com/MSBuildExtensionPack")]
[assembly: AssemblyTrademark("Mike Fourie")]
[assembly:NeutralResourcesLanguage("en-GB")]
[assembly:AssemblyCulture("en-GB")]
[assembly: AssemblyProduct("MSBuild Extension Pack")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly:ComVisible(false)]