using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Comparison;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

public sealed class IsGreaterThanZ : BooleanEnvelope
{
	public IsGreaterThanZ
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsGreaterThanFractional(
			new ZOfPoint(first),
			new ZOfPoint(second))
	)
	{
	}
}