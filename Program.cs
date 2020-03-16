﻿using System;

namespace uloc
{
    /// Reference articles:
    /// Microsoft Managed Recommended Rules: 
    ///     https://docs.microsoft.com/en-us/visualstudio/code-quality/managed-recommended-rules-rule-set-for-managed-code?view=vs-2019
    /// Anthony Girettib Blog Post:
    ///     http://anthonygiretti.com/2018/01/24/code-quality-using-codeanalysis-fxcopanalyzers-and-stylecop-in-net-core-2-applications/
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var unusedLocal = 1;
        }
    }

    public class MyStrangeClass
    {
        int state = 0;

        public void MyStrangeMethod(int s)
        {
            // We do not use instanc estate here
        }
    }
}
