using System;

namespace CS_ADVANCE.Jamie_King_ExpressionTrees._01_Intro
{
    public static class _01_Intro
    {
        public static void _01_IntroCaller()
        {
            Func<int, bool> test = i => i > 5; // 1.  [CS file] ->CSC.EXE-> 2. [MSIL (.NET)] -> JIT -> 3. [NA (NativeAssembly)(CPU)]
            Console.WriteLine(test(3));
        }
    }
}