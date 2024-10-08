using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SDL.SourceGeneration;

public record GeneratedMethod
{
    public readonly MethodDeclarationSyntax NativeMethod;
    public readonly Changes RequiredChanges;

    public GeneratedMethod(MethodDeclarationSyntax nativeMethod, Changes requiredChanges)
    {
        NativeMethod = nativeMethod;
        RequiredChanges = requiredChanges;
    }
}