using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Product.Scalar.With.Point;

public sealed class Multiple : Envelope<Any>
{
	public Multiple
	(
		params Any<Any>[] array
	) : this
	(
		new List<Any<Any>>(array)
	)
	{
	}

	public Multiple
	(
		IEnumerable<Any<Any>> spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}
	
	public Multiple
	(
		ICollection<Any<Any>> collection
	) : base
	(
		new Unique<Any>(
			new Mathematics.Arithmetic.Numerical.Real.Product.Scalar.Of.Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.X.Value.Enumerable(collection)),
			new Mathematics.Arithmetic.Numerical.Real.Product.Scalar.Of.Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.Y.Value.Enumerable(collection)),
			new Mathematics.Arithmetic.Numerical.Real.Product.Scalar.Of.Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.Z.Value.Enumerable(collection)))
	)
	{
	}
}