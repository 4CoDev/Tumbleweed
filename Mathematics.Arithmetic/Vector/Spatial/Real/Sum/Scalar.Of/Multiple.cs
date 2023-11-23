using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Sum.Scalar.Of;

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
			new Mathematics.Arithmetic.Numerical.Real.Sum.Scalar.Of.Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.X.Value.Enumerable(spatials)),
			new Mathematics.Arithmetic.Numerical.Real.Sum.Scalar.Of.Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.Y.Value.Enumerable(spatials)),
			new Mathematics.Arithmetic.Numerical.Real.Sum.Scalar.Of.Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.Z.Value.Enumerable(spatials)))
	)
	{
	}
}