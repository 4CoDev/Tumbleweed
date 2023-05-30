using Tumbleweed._Boolean;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;

namespace Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

public sealed class IsLessThanZ : BooleanEnvelope
{
	public IsLessThanZ
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new ZOfPoint(first),
			new ZOfPoint(second))
	)
	{
	}
}