using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Sum.Scalar.Of;

public sealed class Multiple : Envelope<Any>
{
	public Multiple
	(
		params Any<Any>[] summands
	) : this
	(
		new List<Any<Any>>(summands)
	)
	{
	}

	public Multiple
	(
		IEnumerable<Any<Any>> summands
	) : this
	(
		new List<Any<Any>>(summands)
	)
	{
	}
	
	public Multiple
	(
		ICollection<Any<Any>> spatials
	) : base
	(
		new Unique<Any>(
			new Mathematics.Arithmetic.Real.Sum.Scalar.Of.Multiple(new Coordinate.X.Value.Enumerable(spatials)),
			new Mathematics.Arithmetic.Real.Sum.Scalar.Of.Multiple(new Coordinate.Y.Value.Enumerable(spatials)),
			new Mathematics.Arithmetic.Real.Sum.Scalar.Of.Multiple(new Coordinate.Z.Value.Enumerable(spatials)))
	)
	{
	}
}