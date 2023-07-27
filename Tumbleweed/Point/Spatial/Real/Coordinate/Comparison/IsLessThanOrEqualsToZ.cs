using Tumbleweed.Boolean.Comparison.Either.Is;
using Any = Tumbleweed.Number.Real.Any;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

public sealed class IsLessThanOrEqualsToZ : Boolean.Envelope
{
	public IsLessThanOrEqualsToZ
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new IsLessThanZ(first, second),
			new IsEqualsToZ(first, second))
	)
	{
	}
}