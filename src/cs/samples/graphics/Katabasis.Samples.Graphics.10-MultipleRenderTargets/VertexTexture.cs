// Copyright (c) Craftworkgames (https://github.com/craftworkgames). All rights reserved.
// Licensed under the MS-PL license. See LICENSE file in the Git repository root directory (https://github.com/craftworkgames/Katabasis) for full license information.
using System.Numerics;

namespace Katabasis.Samples
{
	internal struct VertexTexture : IVertexType
	{
		public Vector2 TextureCoordinates;

		public static readonly VertexDeclaration Declaration;

		VertexDeclaration IVertexType.VertexDeclaration => Declaration;

		static VertexTexture()
		{
			var elements = new[]
			{
				new VertexElement(
					0, VertexElementFormat.Vector2, VertexElementUsage.TextureCoordinate, 0)
			};

			Declaration = new VertexDeclaration(elements);
		}
	}
}
