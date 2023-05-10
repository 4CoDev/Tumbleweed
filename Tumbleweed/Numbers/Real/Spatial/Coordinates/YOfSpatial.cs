using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class YOfSpatial : RealEnvelope
{
	public YOfSpatial(ISpatial<IReal> spatial) : base
	(
		new RealOfScalar(
			new YOfSpatial<IReal>(spatial))
	)
	{
	}
}