using Tumbleweed.Number.Real;
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
			new Tumbleweed.Number.Real.Arithmetic.Product.Scalar.Of.Multiple(new Coordinate.X.Value.Enumerable(collection)),
			new Tumbleweed.Number.Real.Arithmetic.Product.Scalar.Of.Multiple(new Coordinate.Y.Value.Enumerable(collection)),
			new Tumbleweed.Number.Real.Arithmetic.Product.Scalar.Of.Multiple(new Coordinate.Z.Value.Enumerable(collection)))
	)
	{
	}
}