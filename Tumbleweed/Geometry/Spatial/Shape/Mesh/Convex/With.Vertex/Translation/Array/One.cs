using Tumbleweed.Point.Spatial.Generic;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.With.Vertex.Translation.Array;

public sealed class One : Envelope
{
	public One(params Any<Real::Any>[] translations) : base
	(
		new Enumerable.One(translations)
	)
	{
	}
}