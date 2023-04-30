using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsEqualsToY : BooleanEnvelope
{
	public IsEqualsToY
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new IsEqualsToFractional(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}