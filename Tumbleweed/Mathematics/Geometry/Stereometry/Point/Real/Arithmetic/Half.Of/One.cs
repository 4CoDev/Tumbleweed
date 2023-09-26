using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Half.Of;

public sealed class One : Envelope<Any>
{
	public One
	(
		Any<Any> whole
	) : base
	(
		new Unique(
			new Coordinate.X.Arithmetic.Half.Of.One(whole),
			new Coordinate.Y.Arithmetic.Half.Of.One(whole),
			new Coordinate.Z.Arithmetic.Half.Of.One(whole))
	)
	{
	}
}