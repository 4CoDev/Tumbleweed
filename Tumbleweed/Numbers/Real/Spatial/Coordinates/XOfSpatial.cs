using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class XOfSpatial : RealEnvelope
{
	public XOfSpatial(ISpatial<IReal> spatial) : base
	(
		new RealOfScalar(
			new XOfSpatial<IReal>(spatial))
	)
	{
	}
}