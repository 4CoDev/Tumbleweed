using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsLessThanOrEqualsToY : BooleanEnvelope
{
	public IsLessThanOrEqualsToY
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsLessThanY(first, second),
			new IsEqualsToY(first, second))
	)
	{
	}
}