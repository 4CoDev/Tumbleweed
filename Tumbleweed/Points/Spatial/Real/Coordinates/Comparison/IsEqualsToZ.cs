using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Comparison;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

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