// Generated from https://raw.githubusercontent.com/mattbrailsford/Nuke.UmbPack/dev/src/Nuke.UmbPack/Specifications/UmbPack.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

/// <summary>
///   <p>UmbPack is a CLI tool to use in CI/CD to upload Umbraco .zip packages to the our.umbraco.com package repository.</p>
///   <p>For more details, visit the <a href="https://github.com/umbraco/UmbPack">official website</a>.</p>
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class UmbPackTasks
{
    /// <summary>
    ///   Path to the UmbPack executable.
    /// </summary>
    public static string UmbPackPath =>
        ToolPathResolver.TryGetEnvironmentExecutable("UMBPACK_EXE") ??
        ToolPathResolver.GetPackageExecutable("Umbraco.Tools.Packages", "UmbPack.dll");
    public static Action<OutputType, string> UmbPackLogger { get; set; } = ProcessTasks.DefaultLogger;
    /// <summary>
    ///   <p>UmbPack is a CLI tool to use in CI/CD to upload Umbraco .zip packages to the our.umbraco.com package repository.</p>
    ///   <p>For more details, visit the <a href="https://github.com/umbraco/UmbPack">official website</a>.</p>
    /// </summary>
    public static IReadOnlyCollection<Output> UmbPack(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
    {
        var process = ProcessTasks.StartProcess(UmbPackPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, UmbPackLogger, outputFilter);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>UmbPack is a CLI tool to use in CI/CD to upload Umbraco .zip packages to the our.umbraco.com package repository.</p>
    ///   <p>For more details, visit the <a href="https://github.com/umbraco/UmbPack">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;targetPath&gt;</c> via <see cref="UmbPackPackSettings.TargetPath"/></li>
    ///     <li><c>-o</c> via <see cref="UmbPackPackSettings.OutputDirectory"/></li>
    ///     <li><c>-v</c> via <see cref="UmbPackPackSettings.Version"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> UmbPackPack(UmbPackPackSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new UmbPackPackSettings();
        var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>UmbPack is a CLI tool to use in CI/CD to upload Umbraco .zip packages to the our.umbraco.com package repository.</p>
    ///   <p>For more details, visit the <a href="https://github.com/umbraco/UmbPack">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;targetPath&gt;</c> via <see cref="UmbPackPackSettings.TargetPath"/></li>
    ///     <li><c>-o</c> via <see cref="UmbPackPackSettings.OutputDirectory"/></li>
    ///     <li><c>-v</c> via <see cref="UmbPackPackSettings.Version"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> UmbPackPack(Configure<UmbPackPackSettings> configurator)
    {
        return UmbPackPack(configurator(new UmbPackPackSettings()));
    }
    /// <summary>
    ///   <p>UmbPack is a CLI tool to use in CI/CD to upload Umbraco .zip packages to the our.umbraco.com package repository.</p>
    ///   <p>For more details, visit the <a href="https://github.com/umbraco/UmbPack">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;targetPath&gt;</c> via <see cref="UmbPackPackSettings.TargetPath"/></li>
    ///     <li><c>-o</c> via <see cref="UmbPackPackSettings.OutputDirectory"/></li>
    ///     <li><c>-v</c> via <see cref="UmbPackPackSettings.Version"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(UmbPackPackSettings Settings, IReadOnlyCollection<Output> Output)> UmbPackPack(CombinatorialConfigure<UmbPackPackSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(UmbPackPack, UmbPackLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>UmbPack is a CLI tool to use in CI/CD to upload Umbraco .zip packages to the our.umbraco.com package repository.</p>
    ///   <p>For more details, visit the <a href="https://github.com/umbraco/UmbPack">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;targetPath&gt;</c> via <see cref="UmbPackPushSettings.TargetPath"/></li>
    ///     <li><c>-a</c> via <see cref="UmbPackPushSettings.Archive"/></li>
    ///     <li><c>-c</c> via <see cref="UmbPackPushSettings.Current"/></li>
    ///     <li><c>-DotNetVersion</c> via <see cref="UmbPackPushSettings.DotNetVersion"/></li>
    ///     <li><c>-k</c> via <see cref="UmbPackPushSettings.ApiKey"/></li>
    ///     <li><c>-w</c> via <see cref="UmbPackPushSettings.WorksWith"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> UmbPackPush(UmbPackPushSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new UmbPackPushSettings();
        var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>UmbPack is a CLI tool to use in CI/CD to upload Umbraco .zip packages to the our.umbraco.com package repository.</p>
    ///   <p>For more details, visit the <a href="https://github.com/umbraco/UmbPack">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;targetPath&gt;</c> via <see cref="UmbPackPushSettings.TargetPath"/></li>
    ///     <li><c>-a</c> via <see cref="UmbPackPushSettings.Archive"/></li>
    ///     <li><c>-c</c> via <see cref="UmbPackPushSettings.Current"/></li>
    ///     <li><c>-DotNetVersion</c> via <see cref="UmbPackPushSettings.DotNetVersion"/></li>
    ///     <li><c>-k</c> via <see cref="UmbPackPushSettings.ApiKey"/></li>
    ///     <li><c>-w</c> via <see cref="UmbPackPushSettings.WorksWith"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> UmbPackPush(Configure<UmbPackPushSettings> configurator)
    {
        return UmbPackPush(configurator(new UmbPackPushSettings()));
    }
    /// <summary>
    ///   <p>UmbPack is a CLI tool to use in CI/CD to upload Umbraco .zip packages to the our.umbraco.com package repository.</p>
    ///   <p>For more details, visit the <a href="https://github.com/umbraco/UmbPack">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;targetPath&gt;</c> via <see cref="UmbPackPushSettings.TargetPath"/></li>
    ///     <li><c>-a</c> via <see cref="UmbPackPushSettings.Archive"/></li>
    ///     <li><c>-c</c> via <see cref="UmbPackPushSettings.Current"/></li>
    ///     <li><c>-DotNetVersion</c> via <see cref="UmbPackPushSettings.DotNetVersion"/></li>
    ///     <li><c>-k</c> via <see cref="UmbPackPushSettings.ApiKey"/></li>
    ///     <li><c>-w</c> via <see cref="UmbPackPushSettings.WorksWith"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(UmbPackPushSettings Settings, IReadOnlyCollection<Output> Output)> UmbPackPush(CombinatorialConfigure<UmbPackPushSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(UmbPackPush, UmbPackLogger, degreeOfParallelism, completeOnFailure);
    }
}
#region UmbPackPackSettings
/// <summary>
///   Used within <see cref="UmbPackTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class UmbPackPackSettings : ToolSettings
{
    /// <summary>
    ///   Path to the UmbPack executable.
    /// </summary>
    public override string ToolPath => base.ToolPath ?? UmbPackTasks.UmbPackPath;
    public override Action<OutputType, string> CustomLogger => UmbPackTasks.UmbPackLogger;
    /// <summary>
    ///   The package.xml file or folder you want to create your package from
    /// </summary>
    public virtual string TargetPath { get; internal set; }
    /// <summary>
    ///   The directory the created package will be saved to
    /// </summary>
    public virtual string OutputDirectory { get; internal set; }
    /// <summary>
    ///   Override the version defined in the package.xml file
    /// </summary>
    public virtual string Version { get; internal set; }
    protected override Arguments ConfigureArguments(Arguments arguments)
    {
        arguments
          .Add("pack")
          .Add("{value}", TargetPath)
          .Add("-o {value}", OutputDirectory)
          .Add("-v {value}", Version);
        return base.ConfigureArguments(arguments);
    }
}
#endregion
#region UmbPackPushSettings
/// <summary>
///   Used within <see cref="UmbPackTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class UmbPackPushSettings : ToolSettings
{
    /// <summary>
    ///   Path to the UmbPack executable.
    /// </summary>
    public override string ToolPath => base.ToolPath ?? UmbPackTasks.UmbPackPath;
    public override Action<OutputType, string> CustomLogger => UmbPackTasks.UmbPackLogger;
    /// <summary>
    ///   Path to the package.zip file you wish to push
    /// </summary>
    public virtual string TargetPath { get; internal set; }
    /// <summary>
    ///   Api Key to use
    /// </summary>
    public virtual string ApiKey { get; internal set; }
    /// <summary>
    ///   Change the required DotNetVersion for the package
    /// </summary>
    public virtual string DotNetVersion { get; internal set; }
    /// <summary>
    ///   Make this package the current package file
    /// </summary>
    public virtual bool? Current { get; internal set; }
    /// <summary>
    ///   Compatible Umbraco versions
    /// </summary>
    public virtual IReadOnlyList<string> WorksWith => WorksWithInternal.AsReadOnly();
    internal List<string> WorksWithInternal { get; set; } = new List<string>();
    /// <summary>
    ///   One or more wildcard patterns to match against existing package files to be archived
    /// </summary>
    public virtual IReadOnlyList<string> Archive => ArchiveInternal.AsReadOnly();
    internal List<string> ArchiveInternal { get; set; } = new List<string>();
    protected override Arguments ConfigureArguments(Arguments arguments)
    {
        arguments
          .Add("push")
          .Add("{value}", TargetPath)
          .Add("-k {value}", ApiKey, secret: true)
          .Add("-DotNetVersion {value}", DotNetVersion)
          .Add("-c {value}", Current)
          .Add("-w {value}", WorksWith, separator: ',')
          .Add("-a {value}", Archive, separator: ' ');
        return base.ConfigureArguments(arguments);
    }
}
#endregion
#region UmbPackPackSettingsExtensions
/// <summary>
///   Used within <see cref="UmbPackTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class UmbPackPackSettingsExtensions
{
    #region TargetPath
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPackSettings.TargetPath"/></em></p>
    ///   <p>The package.xml file or folder you want to create your package from</p>
    /// </summary>
    [Pure]
    public static T SetTargetPath<T>(this T toolSettings, string targetPath) where T : UmbPackPackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetPath = targetPath;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="UmbPackPackSettings.TargetPath"/></em></p>
    ///   <p>The package.xml file or folder you want to create your package from</p>
    /// </summary>
    [Pure]
    public static T ResetTargetPath<T>(this T toolSettings) where T : UmbPackPackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetPath = null;
        return toolSettings;
    }
    #endregion
    #region OutputDirectory
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPackSettings.OutputDirectory"/></em></p>
    ///   <p>The directory the created package will be saved to</p>
    /// </summary>
    [Pure]
    public static T SetOutputDirectory<T>(this T toolSettings, string outputDirectory) where T : UmbPackPackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.OutputDirectory = outputDirectory;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="UmbPackPackSettings.OutputDirectory"/></em></p>
    ///   <p>The directory the created package will be saved to</p>
    /// </summary>
    [Pure]
    public static T ResetOutputDirectory<T>(this T toolSettings) where T : UmbPackPackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.OutputDirectory = null;
        return toolSettings;
    }
    #endregion
    #region Version
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPackSettings.Version"/></em></p>
    ///   <p>Override the version defined in the package.xml file</p>
    /// </summary>
    [Pure]
    public static T SetVersion<T>(this T toolSettings, string version) where T : UmbPackPackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Version = version;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="UmbPackPackSettings.Version"/></em></p>
    ///   <p>Override the version defined in the package.xml file</p>
    /// </summary>
    [Pure]
    public static T ResetVersion<T>(this T toolSettings) where T : UmbPackPackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Version = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region UmbPackPushSettingsExtensions
/// <summary>
///   Used within <see cref="UmbPackTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class UmbPackPushSettingsExtensions
{
    #region TargetPath
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPushSettings.TargetPath"/></em></p>
    ///   <p>Path to the package.zip file you wish to push</p>
    /// </summary>
    [Pure]
    public static T SetTargetPath<T>(this T toolSettings, string targetPath) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetPath = targetPath;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="UmbPackPushSettings.TargetPath"/></em></p>
    ///   <p>Path to the package.zip file you wish to push</p>
    /// </summary>
    [Pure]
    public static T ResetTargetPath<T>(this T toolSettings) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetPath = null;
        return toolSettings;
    }
    #endregion
    #region ApiKey
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPushSettings.ApiKey"/></em></p>
    ///   <p>Api Key to use</p>
    /// </summary>
    [Pure]
    public static T SetApiKey<T>(this T toolSettings, string apiKey) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ApiKey = apiKey;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="UmbPackPushSettings.ApiKey"/></em></p>
    ///   <p>Api Key to use</p>
    /// </summary>
    [Pure]
    public static T ResetApiKey<T>(this T toolSettings) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ApiKey = null;
        return toolSettings;
    }
    #endregion
    #region DotNetVersion
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPushSettings.DotNetVersion"/></em></p>
    ///   <p>Change the required DotNetVersion for the package</p>
    /// </summary>
    [Pure]
    public static T SetDotNetVersion<T>(this T toolSettings, string dotNetVersion) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DotNetVersion = dotNetVersion;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="UmbPackPushSettings.DotNetVersion"/></em></p>
    ///   <p>Change the required DotNetVersion for the package</p>
    /// </summary>
    [Pure]
    public static T ResetDotNetVersion<T>(this T toolSettings) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DotNetVersion = null;
        return toolSettings;
    }
    #endregion
    #region Current
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPushSettings.Current"/></em></p>
    ///   <p>Make this package the current package file</p>
    /// </summary>
    [Pure]
    public static T SetCurrent<T>(this T toolSettings, bool? current) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Current = current;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="UmbPackPushSettings.Current"/></em></p>
    ///   <p>Make this package the current package file</p>
    /// </summary>
    [Pure]
    public static T ResetCurrent<T>(this T toolSettings) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Current = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="UmbPackPushSettings.Current"/></em></p>
    ///   <p>Make this package the current package file</p>
    /// </summary>
    [Pure]
    public static T EnableCurrent<T>(this T toolSettings) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Current = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="UmbPackPushSettings.Current"/></em></p>
    ///   <p>Make this package the current package file</p>
    /// </summary>
    [Pure]
    public static T DisableCurrent<T>(this T toolSettings) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Current = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="UmbPackPushSettings.Current"/></em></p>
    ///   <p>Make this package the current package file</p>
    /// </summary>
    [Pure]
    public static T ToggleCurrent<T>(this T toolSettings) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Current = !toolSettings.Current;
        return toolSettings;
    }
    #endregion
    #region WorksWith
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPushSettings.WorksWith"/> to a new list</em></p>
    ///   <p>Compatible Umbraco versions</p>
    /// </summary>
    [Pure]
    public static T SetWorksWith<T>(this T toolSettings, params string[] worksWith) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.WorksWithInternal = worksWith.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPushSettings.WorksWith"/> to a new list</em></p>
    ///   <p>Compatible Umbraco versions</p>
    /// </summary>
    [Pure]
    public static T SetWorksWith<T>(this T toolSettings, IEnumerable<string> worksWith) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.WorksWithInternal = worksWith.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="UmbPackPushSettings.WorksWith"/></em></p>
    ///   <p>Compatible Umbraco versions</p>
    /// </summary>
    [Pure]
    public static T AddWorksWith<T>(this T toolSettings, params string[] worksWith) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.WorksWithInternal.AddRange(worksWith);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="UmbPackPushSettings.WorksWith"/></em></p>
    ///   <p>Compatible Umbraco versions</p>
    /// </summary>
    [Pure]
    public static T AddWorksWith<T>(this T toolSettings, IEnumerable<string> worksWith) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.WorksWithInternal.AddRange(worksWith);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="UmbPackPushSettings.WorksWith"/></em></p>
    ///   <p>Compatible Umbraco versions</p>
    /// </summary>
    [Pure]
    public static T ClearWorksWith<T>(this T toolSettings) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.WorksWithInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="UmbPackPushSettings.WorksWith"/></em></p>
    ///   <p>Compatible Umbraco versions</p>
    /// </summary>
    [Pure]
    public static T RemoveWorksWith<T>(this T toolSettings, params string[] worksWith) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(worksWith);
        toolSettings.WorksWithInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="UmbPackPushSettings.WorksWith"/></em></p>
    ///   <p>Compatible Umbraco versions</p>
    /// </summary>
    [Pure]
    public static T RemoveWorksWith<T>(this T toolSettings, IEnumerable<string> worksWith) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(worksWith);
        toolSettings.WorksWithInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region Archive
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPushSettings.Archive"/> to a new list</em></p>
    ///   <p>One or more wildcard patterns to match against existing package files to be archived</p>
    /// </summary>
    [Pure]
    public static T SetArchive<T>(this T toolSettings, params string[] archive) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ArchiveInternal = archive.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="UmbPackPushSettings.Archive"/> to a new list</em></p>
    ///   <p>One or more wildcard patterns to match against existing package files to be archived</p>
    /// </summary>
    [Pure]
    public static T SetArchive<T>(this T toolSettings, IEnumerable<string> archive) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ArchiveInternal = archive.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="UmbPackPushSettings.Archive"/></em></p>
    ///   <p>One or more wildcard patterns to match against existing package files to be archived</p>
    /// </summary>
    [Pure]
    public static T AddArchive<T>(this T toolSettings, params string[] archive) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ArchiveInternal.AddRange(archive);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="UmbPackPushSettings.Archive"/></em></p>
    ///   <p>One or more wildcard patterns to match against existing package files to be archived</p>
    /// </summary>
    [Pure]
    public static T AddArchive<T>(this T toolSettings, IEnumerable<string> archive) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ArchiveInternal.AddRange(archive);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="UmbPackPushSettings.Archive"/></em></p>
    ///   <p>One or more wildcard patterns to match against existing package files to be archived</p>
    /// </summary>
    [Pure]
    public static T ClearArchive<T>(this T toolSettings) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ArchiveInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="UmbPackPushSettings.Archive"/></em></p>
    ///   <p>One or more wildcard patterns to match against existing package files to be archived</p>
    /// </summary>
    [Pure]
    public static T RemoveArchive<T>(this T toolSettings, params string[] archive) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(archive);
        toolSettings.ArchiveInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="UmbPackPushSettings.Archive"/></em></p>
    ///   <p>One or more wildcard patterns to match against existing package files to be archived</p>
    /// </summary>
    [Pure]
    public static T RemoveArchive<T>(this T toolSettings, IEnumerable<string> archive) where T : UmbPackPushSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(archive);
        toolSettings.ArchiveInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
}
#endregion
