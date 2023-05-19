using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Comparison;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

public sealed class IsEqualsToY : BooleanEnvelope
{
	public IsEqualsToY
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsEqualsToFractional(
			new YOfPoint(first),
			new YOfPoint(second))
	)
	{
	}
}