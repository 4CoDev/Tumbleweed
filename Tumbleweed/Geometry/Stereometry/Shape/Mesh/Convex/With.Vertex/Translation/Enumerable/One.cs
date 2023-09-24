using Tumbleweed.Point.Spatial.Generic;
using SCG = System.Collections.Generic;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Translation.Enumerable;

public sealed class One : Envelope
{
	public One
	(
		SCG::IEnumerable<Any<Mathematics.Number.Real.Any>> translations
	) : base
	(
		new Whole.Enumerable.One(
			new Stereometry.Vertex.With.Translation.Enumerable(translations))
	)
	{
	}
}