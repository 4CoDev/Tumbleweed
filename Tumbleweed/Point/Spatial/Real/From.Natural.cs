using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Natural.Coordinate;
using Tumbleweed.Point.Spatial.Real.With.Coordinate.Definition;
using Any = Tumbleweed.Number.Real.Any;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Spatial.Implementation.Real.From;

public sealed class Natural : Envelope<Any>
{
	public Natural(Any<Number.Natural.Any> natural) : base
	(
		new Unique(
			new Number.Real.From.Natural.As.Positive(new X(natural)),
			new Number.Real.From.Natural.As.Positive(new Y(natural)),
			new Number.Real.From.Natural.As.Positive(new Z(natural)))
	)
	{
	}
}