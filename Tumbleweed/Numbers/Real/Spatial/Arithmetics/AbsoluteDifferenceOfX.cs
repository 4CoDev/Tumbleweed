using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class AbsoluteDifferenceOfX : RealEnvelope
{
	public AbsoluteDifferenceOfX
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	) : base
	(
		new AbsoluteDifferenceOfReals(
			new XOfSpatial(first),
			new XOfSpatial(second))
	)
	{
	}
}