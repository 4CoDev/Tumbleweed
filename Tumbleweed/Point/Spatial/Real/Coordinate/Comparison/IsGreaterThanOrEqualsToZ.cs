using Tumbleweed.Boolean.Comparison.Either.Is;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsGreaterThanOrEqualsToZ : Boolean.Envelope
{
	public IsGreaterThanOrEqualsToZ
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new IsGreaterThanZ(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}