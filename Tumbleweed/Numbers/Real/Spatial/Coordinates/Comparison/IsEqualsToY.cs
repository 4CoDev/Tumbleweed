using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsEqualsToY : BooleanEnvelope
{
	public IsEqualsToY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsEqualsToFractional(
			new YOfSpatial(first),
			new YOfSpatial(second))
	)
	{
	}
}