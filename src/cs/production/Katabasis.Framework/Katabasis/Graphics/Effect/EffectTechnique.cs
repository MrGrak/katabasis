// Copyright (c) Craftworkgames (https://github.com/craftworkgames). All rights reserved.
// Licensed under the MS-PL license. See LICENSE file in the Git repository root directory (https://github.com/craftworkgames/Katabasis) for full license information.
using System;

namespace Katabasis
{
	public sealed class EffectTechnique
	{
		internal EffectTechnique(
			string? name,
			IntPtr pointer,
			EffectPassCollection passes,
			EffectAnnotationCollection annotations)
		{
			Name = name ?? string.Empty;
			Passes = passes;
			Annotations = annotations;
			TechniquePointer = pointer;
		}

		public string Name { get; }

		public EffectPassCollection Passes { get; }

		public EffectAnnotationCollection Annotations { get; }

		internal IntPtr TechniquePointer { get; }
	}
}
