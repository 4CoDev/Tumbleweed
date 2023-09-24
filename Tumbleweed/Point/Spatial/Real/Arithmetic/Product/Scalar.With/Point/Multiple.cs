using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Product.Scalar.With.Point;

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
			new Mathematics.Arithmetic.Real.Product.Scalar.Of.Multiple(new Coordinate.X.Value.Enumerable(collection)),
			new Mathematics.Arithmetic.Real.Product.Scalar.Of.Multiple(new Coordinate.Y.Value.Enumerable(collection)),
			new Mathematics.Arithmetic.Real.Product.Scalar.Of.Multiple(new Coordinate.Z.Value.Enumerable(collection)))
	)
	{
	}
}