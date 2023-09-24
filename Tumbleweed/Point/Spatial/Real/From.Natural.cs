using Tumbleweed.Mathematics.Number.Real.From.Natural.As;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Natural.Coordinate;
using Tumbleweed.Point.Spatial.Real.With.Coordinate.Definition;
using Any = Tumbleweed.Mathematics.Number.Real.Any;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Spatial.Implementation.Real.From;

public sealed class Natural : Envelope<Any>
{
	public Natural(Any<Mathematics.Number.Natural.Any> natural) : base
	(
		new Unique(
			new Positive(new X(natural)),
			new Positive(new Y(natural)),
			new Positive(new Z(natural)))
	)
	{
	}
}