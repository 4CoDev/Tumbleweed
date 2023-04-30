using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class AbsoluteDifferenceOfZ : RealEnvelope
{
	public AbsoluteDifferenceOfZ
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new ZOfSpatial(first),
			new ZOfSpatial(second))
	)
	{
	}
}