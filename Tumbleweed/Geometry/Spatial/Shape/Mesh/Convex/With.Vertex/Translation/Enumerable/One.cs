using Tumbleweed.Point.Spatial.Generic;
using SCG = System.Collections.Generic;
using Real = Tumbleweed.Number.Real;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.With.Vertex.Translation.Enumerable;

public sealed class One : Envelope
{
	public One
	(
		SCG::IEnumerable<Any<Real::Any>> translations
	) : base
	(
		new Whole.Enumerable.One(
			new Vertex::With.Translation.Enumerable(translations))
	)
	{
	}
}