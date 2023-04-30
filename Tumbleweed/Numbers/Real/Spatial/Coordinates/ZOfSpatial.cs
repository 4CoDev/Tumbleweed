using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class ZOfSpatial : RealEnvelope
{
	public ZOfSpatial(ISpatial<IReal> spatial) : base
	(
		new RealOfScalar(
			new ZOfSpatial<IReal>(spatial))
	)
	{
	}
}