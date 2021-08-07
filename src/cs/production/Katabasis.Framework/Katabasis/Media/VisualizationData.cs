// Copyright (c) Craftworkgames (https://github.com/craftworkgames). All rights reserved.
// Licensed under the MS-PL license. See LICENSE file in the Git repository root directory (https://github.com/craftworkgames/Katabasis) for full license information.
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace Katabasis
{
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "TODO: Not used?")]
	public class VisualizationData
	{
		internal const int Size = 256;

		internal float[] _frequencies;
		internal float[] _samples;

		public VisualizationData()
		{
			_frequencies = new float[Size];
			_samples = new float[Size];
		}

		public ReadOnlyCollection<float> Frequencies => new(_frequencies);

		public ReadOnlyCollection<float> Samples => new(_samples);
	}
}
