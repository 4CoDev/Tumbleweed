using Tumbleweed.Boolean.Comparison.Either.Is;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate.Comparison;

public sealed class IsGreaterThanOrEqualsToY : Boolean.Envelope
{
	public IsGreaterThanOrEqualsToY
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new IsGreaterThanY(first, second),
			new IsEqualsToY(first, second))
	)
	{
	}
}