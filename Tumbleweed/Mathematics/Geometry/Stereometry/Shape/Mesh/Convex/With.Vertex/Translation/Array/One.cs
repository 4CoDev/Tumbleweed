using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Translation.Array;

public sealed class One : Envelope
{
	public One(params Any<Mathematics.Number.Real.Any>[] translations) : base
	(
		new Enumerable.One(translations)
	)
	{
	}
}