﻿using System.Reflection;

namespace ApplicationLayer;
public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}
