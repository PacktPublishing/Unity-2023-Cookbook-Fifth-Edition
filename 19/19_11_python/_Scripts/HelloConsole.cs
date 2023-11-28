using UnityEditor.Scripting.Python;
using UnityEditor;

public class HelloConsole
{
    [MenuItem("My Python/Hello Console")]
    static void PrintHelloWorldFromPython()
    {
        string pythonCode = @"
                import UnityEngine;
                UnityEngine.Debug.Log('hello console')
                ";
        PythonRunner.RunString(pythonCode);
    }
}
