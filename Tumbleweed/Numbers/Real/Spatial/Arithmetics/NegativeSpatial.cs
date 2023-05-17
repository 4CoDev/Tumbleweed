using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class NegativeSpatial : SpatialEnvelope<IReal>
{
	public NegativeSpatial
	(
		ISpatial<IReal> spatial
	) : base
	(
		new SpatialWithCoordinates<IReal>(
			new NegativeReal(new XOfSpatial(spatial)),
			new NegativeReal(new YOfSpatial(spatial)),
			new NegativeReal(new ZOfSpatial(spatial)))
	)
	{
	}
}