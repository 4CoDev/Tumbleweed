using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Comparison;

namespace Tumbleweed.Points.Spatial.Real.Coordinates.Comparison;

public sealed class IsLessThanX : BooleanEnvelope
{
	public IsLessThanX
	(
		IPoint<IReal> first,
		IPoint<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new XOfPoint(first),
			new XOfPoint(second))
	)
	{
	}
}