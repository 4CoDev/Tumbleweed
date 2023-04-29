using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numerics.Fractional.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates.Comparison;

public sealed class IsLessThanOrEqualsToX : BooleanEnvelope
{
	public IsLessThanOrEqualsToX
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsLessThanX(first, second),
			new IsEqualsToX(first, second))
	)
	{
	}
}