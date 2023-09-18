using Tumbleweed.Point.Spatial.Generic;
using Enumerable = Tumbleweed.Enumerable;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using SCG = System.Collections.Generic;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Vertex.With.Translation;

public sealed class Enumerable : Enumerable::Envelope<Vertex::Any>
{
	public Enumerable
	(
		SCG::IEnumerable<Any<Real::Any>> translations
	) : base
	(
		new Enumerable::Selected
		<
			Any<Real::Any>,
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