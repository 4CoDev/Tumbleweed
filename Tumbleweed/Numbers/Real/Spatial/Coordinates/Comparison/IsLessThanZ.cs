using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates.Comparison;

public sealed class IsLessThanZ : BooleanEnvelope
{
	public IsLessThanZ
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new IsLessThanFractional(
			new ZOfSpatial(first),
			new ZOfSpatial(second))
	)
	{
	}
}