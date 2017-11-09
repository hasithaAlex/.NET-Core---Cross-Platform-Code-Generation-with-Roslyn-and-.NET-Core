using System;
using System.Runtime.Loader;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Reflection;
using System.IO;
using System.Linq;


namespace RoslynCore
{
    class Program
    {
       public static void Main(string[] args)
        {
            /*
            * Learn how to invoke the C# compiler in .NET Core applications that run on Linux, 
            * Mac and Windows to perform code generation with the Roslyn APIs, using
            * Visual Studio Code as the development environment.        
            */
            //new DiagnosticSourceCode().runDiagnosticSourceCode();


            new GenerateClass().CreateClass();

        }
    }
}
