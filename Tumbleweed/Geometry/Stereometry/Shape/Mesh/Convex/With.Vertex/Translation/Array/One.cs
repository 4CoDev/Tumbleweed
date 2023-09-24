using Tumbleweed.Point.Spatial.Generic;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Translation.Array;

public sealed class One : Envelope
{
	public One(params Any<Mathematics.Number.Real.Any>[] translations) : base
	(
		new Enumerable.One(translations)
	)
	{
	}
}