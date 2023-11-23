using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.X.Arithmetic.Difference.Absolute.Of;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;
using One = Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Z.Arithmetic.Difference.Absolute.Of.One;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Distance;

public sealed class L1 : Envelope<Any>
{
	public L1
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Unique(
			new Two(first, second),
			new Mathematics.Vector.Spatial.Real.Coordinate.Y.Arithmetic.Difference.Absolute.Of.One(first, second),
			new One(first, second))
	)
	{
	}
}