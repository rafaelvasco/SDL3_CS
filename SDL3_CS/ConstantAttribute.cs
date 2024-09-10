using System.Diagnostics;

namespace SDL;

/// <summary>
/// Denotes a manually defined constant.
/// Such constants should be excluded from ClangSharp generation to prevent warnings or duplicate definitions.
/// Handled by <c>get_manually_written_symbols()</c> in generate_bindings.py.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
[Conditional("NEVER")]
public class ConstantAttribute : Attribute;