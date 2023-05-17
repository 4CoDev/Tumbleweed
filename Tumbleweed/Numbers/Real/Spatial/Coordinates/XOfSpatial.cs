using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

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