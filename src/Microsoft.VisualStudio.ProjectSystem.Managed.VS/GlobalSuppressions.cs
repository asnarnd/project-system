﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1063:Implement IDisposable Correctly", Justification = "https://github.com/dotnet/roslyn-analyzers/issues/1432", Scope = "member", Target = "~M:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.BuildMacroInfo.Dispose")]
[assembly: SuppressMessage("Design", "CA1063:Implement IDisposable Correctly", Justification = "https://github.com/dotnet/roslyn-analyzers/issues/1432", Scope = "member", Target = "~M:Microsoft.VisualStudio.ProjectSystem.VS.References.DesignTimeAssemblyResolution.Dispose")]
[assembly: SuppressMessage("Usage", "VSTHRD110:Observe result of async calls", Justification = "https://github.com/dotnet/project-system/issues/3921", Scope = "member", Target = "~M:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPage.SetObjects(System.UInt32,System.Object[])")]

[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "https://github.com/dotnet/roslyn-analyzers/issues/2416", Scope = "member", Target = "~M:Microsoft.VisualStudio.Telemetry.VsTelemetryService.HashValue(System.String)~System.String")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "https://github.com/dotnet/roslyn-analyzers/issues/2416", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.DebugPageViewModel.BrowseDirectoryCommand")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "https://github.com/dotnet/roslyn-analyzers/issues/2416", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.DebugPageViewModel.BrowseExecutableCommand")]

[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "https://github.com/dotnet/roslyn/issues/41531", Scope = "member", Target = "~M:Microsoft.VisualStudio.ProjectSystem.VS.Automation.VSProject.get_Extender(System.String)~System.Object")]

[assembly: SuppressMessage("ApiDesign", "RS0030:Do not used banned APIs", Justification = "https://github.com/dotnet/roslyn-analyzers/issues/3295", Scope = "member", Target = "~M:Microsoft.VisualStudio.ProjectSystem.VS.TempPE.DesignTimeInputsChangeTracker.Initialize")]
[assembly: SuppressMessage("ApiDesign", "RS0030:Do not used banned APIs", Justification = "https://github.com/dotnet/roslyn-analyzers/issues/3295", Scope = "member", Target = "~M:Microsoft.VisualStudio.ProjectSystem.VS.TempPE.DesignTimeInputsFileWatcher.Initialize")]

[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.AddBtn")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.AllFiles")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ApplicationArguments")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ApplicationArgumentsWatermark")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.AuthenticationMode")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.BrowseBtn")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.CancelBtn")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.CancelBtnHelpText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.chkLaunchBrowserHelpText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.chkNativeCodeDebuggingText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.chkRemoteDebugEnabledHelpText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.chkSqlCodeDebuggingText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.chkJSWebView2DebuggingText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.JSWebView2DebuggingAdditionalText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.Culture")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.DebugPropertyPageTitle")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.DeleteBtn")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.DeleteBtnHelpText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.DuplicateKey")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.EnvironmentVariables")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.EnvVariableNameWatermark")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.EnvVariableValueWatermark")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ErrorsMustBeCorrectedPriorToSaving")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.Executable")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ExecutableFiles")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ExecutablePathWatermark")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.FindBtn")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.InvalidHostName")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.Launch")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.LaunchURL")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.LaunchUrlWatermark")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.NameCannotBeEmpty")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.NameHeader")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.NewBtn")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.NewBtnHelpText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.NewProfileCaption")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.NewProfileSeedName")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.OKBtn")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.OKBtnHelpText")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.Profile")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ProfileKindExecutableName")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ProfileKindIISExpressName")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ProfileKindNoActionName")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ProfileKindProjectName")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ProfileName")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ProfileNameInvalid")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ProfileNameRequired")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.RemoteDebug")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.RemoteDebugMachineWatermark")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.RemoteHostNameRequired")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.RemoveBtn")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ResourceManager")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ValueCannotBeEmpty")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.ValueHeader")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.WorkingDirectoryWatermark")]
[assembly: SuppressMessage("ApiDesign", "RS0041:Public members should not use oblivious types", Justification = "Generated Code", Scope = "member", Target = "~P:Microsoft.VisualStudio.ProjectSystem.VS.PropertyPages.PropertyPageResources.WorkingDirectory")]

[assembly: SuppressMessage("Design", "CA1036:Override methods on comparable types", Justification = "<Pending>", Scope = "type", Target = "~T:Microsoft.VisualStudio.ProjectSystem.VS.Tree.Dependencies.AttachedCollections.AttachedCollectionItemBase")]
[assembly: SuppressMessage("Style", "IDE0008:Use explicit type", Justification = "<Pending>", Scope = "member", Target = "~M:Microsoft.VisualStudio.ProjectSystem.VS.PackageRestore.PackageRestoreUnconfiguredInputDataSource.LinkExternalInput(System.Threading.Tasks.Dataflow.ITargetBlock{Microsoft.VisualStudio.ProjectSystem.IProjectVersionedValue{Microsoft.VisualStudio.ProjectSystem.VS.PackageRestore.PackageRestoreUnconfiguredInput}})~System.IDisposable")]
