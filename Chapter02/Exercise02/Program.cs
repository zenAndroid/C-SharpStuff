﻿using static System.Console;

WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "Type", "Byte(s) of memory", "Min", "Max");
WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "short", sizeof(short), short.MinValue, short.MaxValue);
WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "int", sizeof(int), int.MinValue, int.MaxValue);
WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "long", sizeof(long), long.MinValue, long.MaxValue);
WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "float", sizeof(float), float.MinValue, float.MaxValue);
WriteLine("{0, -8} {1, 1} {2, 30} {3, 30}", "double", sizeof(double), double.MinValue, double.MaxValue);
WriteLine("{0, -8} {1, 1} {2, 30} {3, 37}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

// And here is the book's solution ...

WriteLine("--------------------------------------------------------------------------");
WriteLine("Type    Byte(s) of memory               Min                            Max");
WriteLine("--------------------------------------------------------------------------");
WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
WriteLine("--------------------------------------------------------------------------");

// Alrighty then.