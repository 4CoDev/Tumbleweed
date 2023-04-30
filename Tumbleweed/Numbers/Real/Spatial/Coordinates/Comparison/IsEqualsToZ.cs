using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsEqualsToZ : BooleanEnvelope
{
	public IsEqualsToZ
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new IsEqualsToFractional(
			new ZOfSpatial(first),
			new ZOfSpatial(second))
	)
	{
	}
}