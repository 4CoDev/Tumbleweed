using Tumbleweed.Boolean.Comparison.Either.Is;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate.Comparison;

public sealed class IsLessThanOrEqualsToY : Boolean.Envelope
{
	public IsLessThanOrEqualsToY
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new IsLessThanY(first, second),
			new IsEqualsToY(first, second))
	)
	{
	}
}