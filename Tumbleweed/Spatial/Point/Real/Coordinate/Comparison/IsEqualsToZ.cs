using Tumbleweed._Boolean;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;

namespace Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

public sealed class IsEqualsToZ : BooleanEnvelope
{
	public IsEqualsToZ
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsEqualsToFractional(
			new ZOfPoint(first),
			new ZOfPoint(second))
	)
	{
	}
}