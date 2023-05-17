using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanZ : BooleanEnvelope
{
	public IsGreaterThanZ
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new IsGreaterThanFractional(
			new ZOfSpatial(first),
			new ZOfSpatial(second))
	)
	{
	}
}