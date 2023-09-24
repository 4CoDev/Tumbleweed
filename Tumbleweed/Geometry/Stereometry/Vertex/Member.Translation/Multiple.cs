using Tumbleweed.Point.Spatial.Generic;
using Enumerable = Tumbleweed.Enumerable;
using Real = Tumbleweed.Mathematics.Number.Real;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Stereometry.Vertex.Member.Translation;

public sealed class Multiple : Enumerable::Envelope<Any<Mathematics.Number.Real.Any>>
{
	public Multiple
	(
		SCG::IEnumerable<Any> vertices
	) : base
	(
		new Enumerable::Selected
		<
			Any,
			Any<Mathematics.Number.Real.Any>
		>
		(
			vertices,
			vertex => vertex.Translation
		)
	)
	{
	}
}