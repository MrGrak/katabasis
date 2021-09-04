// Copyright (c) BottlenoseLabs (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MS-PL license. See LICENSE file in the Git repository root directory for full license information.
using System;

namespace Katabasis
{
	public sealed class ResourceCreatedEventArgs : EventArgs
	{
		internal ResourceCreatedEventArgs(object? resource) => Resource = resource;

		public object? Resource { get; }
	}
}
