using Tumbleweed.Numbers.Real.Arithmetics.Rounding;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics.Rounding;

public sealed class NearestIntegerOfSpatial : SpatialEnvelope<IReal>
{
	public NearestIntegerOfSpatial(ISpatial<IReal> spatial) : base
	(
		new SpatialWithCoordinates(
			new NearestIntegerOfReal(new XOfSpatial(spatial)),
			new NearestIntegerOfReal(new YOfSpatial(spatial)),
			new NearestIntegerOfReal(new ZOfSpatial(spatial)))
	)
	{
	}
}