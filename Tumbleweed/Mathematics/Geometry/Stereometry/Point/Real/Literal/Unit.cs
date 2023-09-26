using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Base.Binary.Precision.Single.With.Coordinate.System.Definition;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Literal;

public sealed class Unit : Envelope<Any>
{
	public Unit() : base
	(
		new Uniform(1)
	)
	{
	}
}