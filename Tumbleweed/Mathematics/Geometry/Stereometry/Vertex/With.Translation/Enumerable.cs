using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.With.Translation;

public sealed class Enumerable : Enumerable::Envelope<Any>
{
	public Enumerable
	(
		SCG::IEnumerable<Any<Mathematics.Number.Real.Any>> translations
	) : base
	(
		new Enumerable::Selected
		<
			Any<Mathematics.Number.Real.Any>,
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