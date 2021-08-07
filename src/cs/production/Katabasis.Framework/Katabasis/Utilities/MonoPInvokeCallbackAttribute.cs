﻿// Copyright (c) Craftworkgames (https://github.com/craftworkgames). All rights reserved.
// Licensed under the MS-PL license. See LICENSE file in the Git repository root directory (https://github.com/craftworkgames/Katabasis) for full license information.
using System;

// ReSharper disable once CheckNamespace
namespace ObjCRuntime
{
	[AttributeUsage(AttributeTargets.Method)]
	internal class MonoPInvokeCallbackAttribute : Attribute
	{
		// ReSharper disable once UnusedParameter.Local
		public MonoPInvokeCallbackAttribute(Type t)
		{
		}
	}
}
