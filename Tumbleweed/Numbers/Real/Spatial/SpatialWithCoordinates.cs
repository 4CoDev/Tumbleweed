using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial;

public sealed class SpatialWithCoordinates :
	SpatialEnvelope<IReal>
{
	public SpatialWithCoordinates
	(
		IReal x,
		IReal y,
		IReal z
	) : base
	(
		new SpatialWithCoordinates<IReal>(x, y, z)
	)
	{
	}
}