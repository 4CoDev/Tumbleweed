using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Half.Of;

public sealed class One : Envelope<Any>
{
	public One
	(
		Any<Any> whole
	) : base
	(
		new Unique(
			new Mathematics.Vector.Spatial.Real.Coordinate.X.Arithmetic.Half.Of.One(whole),
			new Mathematics.Vector.Spatial.Real.Coordinate.Y.Arithmetic.Half.Of.One(whole),
			new Mathematics.Vector.Spatial.Real.Coordinate.Z.Arithmetic.Half.Of.One(whole))
	)
	{
	}
}