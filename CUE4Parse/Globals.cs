global using static CUE4Parse.UE4.Versions.EGame;
global using static CUE4Parse.CUE4ParseLog;

using System.Diagnostics.CodeAnalysis;

namespace CUE4Parse;

[SuppressMessage("ReSharper", "ConvertToConstant.Global")]
[SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Global")]
public static class Globals
{
    public static bool LogVfsMounts = true;
    public static bool FatalObjectSerializationErrors = false;
    public static bool WarnMissingImportPackage = true;
    /// <summary>
    /// Skeletal meshes read their render data (LOD models, Nanite resources) when it is first used, not when the mesh loads:
    /// a mesh loaded for its materials, skeleton or sockets does not build its vertex buffers. What is read is the same.
    /// </summary>
    public static bool DeferSkeletalMeshRenderData = false;
    /// <summary>
    /// An IoStore package resolves an import by loading only the package that import is in, and holds it weakly (the file
    /// provider's own cache decides how long it stays): a loaded package no longer keeps every package it imports alive.
    /// What resolves, and to what, is the same.
    /// </summary>
    public static bool WeakImportedPackages = false;
}
