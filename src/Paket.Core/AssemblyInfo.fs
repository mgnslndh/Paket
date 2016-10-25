﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket.Core")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A dependency manager for .NET with support for NuGet packages and git repositories.")>]
[<assembly: AssemblyVersionAttribute("4.0.0")>]
[<assembly: AssemblyFileVersionAttribute("4.0.0")>]
[<assembly: AssemblyInformationalVersionAttribute("4.0.0-alpha009")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "4.0.0"
    let [<Literal>] InformationalVersion = "4.0.0-alpha009"
