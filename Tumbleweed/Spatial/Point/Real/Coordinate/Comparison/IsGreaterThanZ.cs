using Tumbleweed._Boolean;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;

namespace Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

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