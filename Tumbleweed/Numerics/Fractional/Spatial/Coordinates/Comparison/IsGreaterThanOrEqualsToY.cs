using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanOrEqualsToY : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToY
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsGreaterThanY(first, second),
			new IsEqualsToY(first, second))
	)
	{
	}
}