using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsGreaterThanX : BooleanEnvelope
{
	public IsGreaterThanX
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new IsGreaterThanFractional(
			new XOfSpatial(first),
			new XOfSpatial(second))
	)
	{
	}
}