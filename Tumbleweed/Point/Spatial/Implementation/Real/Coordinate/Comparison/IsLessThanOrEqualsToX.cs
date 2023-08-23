using Tumbleweed.Boolean.Comparison.Either.Is;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Coordinate.Comparison;

public sealed class IsLessThanOrEqualsToX : Boolean.Envelope
{
	public IsLessThanOrEqualsToX
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new IsLessThanX(first, second),
			new IsEqualsToX(first, second))
	)
	{
	}
}