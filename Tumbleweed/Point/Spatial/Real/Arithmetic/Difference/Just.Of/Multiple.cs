using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Difference.Just.Of;

public sealed class Multiple : Envelope<Any>
{
	public Multiple
	(
		params Any<Any>[] spatials
	) : this
	(
		new List<Any<Any>>(spatials)
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
		ICollection<Any<Any>> spatials
	) : base
	(
		new Unique<Any>(
			new Mathematics.Arithmetic.Real.Difference.Just.Of.Multiple(new Coordinate.X.Value.Enumerable(spatials)),
			new Mathematics.Arithmetic.Real.Difference.Just.Of.Multiple(new Coordinate.Y.Value.Enumerable(spatials)),
			new Mathematics.Arithmetic.Real.Difference.Just.Of.Multiple(new Coordinate.Z.Value.Enumerable(spatials)))
	)
	{
	}
}