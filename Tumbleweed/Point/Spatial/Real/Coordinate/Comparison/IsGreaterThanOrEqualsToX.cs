using Tumbleweed.Boolean.Comparison.Either.Is;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsGreaterThanOrEqualsToX : Boolean.Envelope
{
	public IsGreaterThanOrEqualsToX
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new IsGreaterThanX(first, second),
			new IsEqualsToX(first, second))
	)
	{
	}
}