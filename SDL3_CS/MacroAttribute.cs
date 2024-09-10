using System.Diagnostics;

namespace SDL;

/// <summary>
/// Denotes a manually implemented macro function.
/// Such functions should be excluded from ClangSharp generation to prevent warnings.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
[Conditional("NEVER")]
internal class MacroAttribute : Attribute;