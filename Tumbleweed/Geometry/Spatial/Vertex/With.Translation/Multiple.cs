using Enumerable = Tumbleweed.Enumerable;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using SCG = System.Collections.Generic;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Vertex.With.Translation;

public sealed class Multiple : Enumerable::Envelope<Vertex::Any>
{
	public Multiple
	(
		SCG::IEnumerable<Point::Any<Real::Any>> translations
	) : base
	(
		new Enumerable::Selected
		<
			Point::Any<Real::Any>,
			Vertex::Any
		>
		(
			translations,
			translation => new One(translation)
		)
	)
	{
	}
}