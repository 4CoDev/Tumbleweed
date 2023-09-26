using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Product.Scalar.With.Point;

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