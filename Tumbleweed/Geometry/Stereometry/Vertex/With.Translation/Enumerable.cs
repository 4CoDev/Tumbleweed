using Tumbleweed.Point.Spatial.Generic;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Vertex.With.Translation;

public sealed class Enumerable : Enumerable::Envelope<Any>
{
	public Enumerable
	(
		SCG::IEnumerable<Any<Real::Any>> translations
	) : base
	(
		new Enumerable::Selected
		<
			Any<Real::Any>,
			Any
		>
		(
			translations,
			translation => new One(translation)
		)
	)
	{
	}
}