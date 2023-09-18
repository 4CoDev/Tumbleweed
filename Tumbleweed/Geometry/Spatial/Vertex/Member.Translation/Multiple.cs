using Tumbleweed.Point.Spatial.Generic;
using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Vertex.Member.Translation;

public sealed class Multiple : Enumerable::Envelope<Any<Real::Any>>
{
	public Multiple
	(
		SCG::IEnumerable<Vertex::Any> vertices
	) : base
	(
		new Enumerable::Selected
		<
			Vertex::Any,
			Any<Real::Any>
		>
		(
			vertices,
			vertex => vertex.Translation
		)
	)
	{
	}
}