using Tumbleweed._Boolean;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;

namespace Tumbleweed.Spatial.Point.Real.Coordinate.Comparison;

public sealed class IsGreaterThanX : BooleanEnvelope
{
	public IsGreaterThanX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsGreaterThanFractional(
			new XOfPoint(first),
			new XOfPoint(second))
	)
	{
	}
}