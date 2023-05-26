using Tumbleweed._Boolean;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Comparison;

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