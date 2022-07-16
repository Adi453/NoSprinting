using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(NoSprinting.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(NoSprinting.BuildInfo.Company)]
[assembly: AssemblyProduct(NoSprinting.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + NoSprinting.BuildInfo.Author)]
[assembly: AssemblyTrademark(NoSprinting.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(NoSprinting.BuildInfo.Version)]
[assembly: AssemblyFileVersion(NoSprinting.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(NoSprinting.NoSprinting), NoSprinting.BuildInfo.Name, NoSprinting.BuildInfo.Version, NoSprinting.BuildInfo.Author, NoSprinting.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]