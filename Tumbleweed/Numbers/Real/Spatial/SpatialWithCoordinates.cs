using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial;

public sealed class PointWithCoordinates :
	PointEnvelope<IReal>
{
	public PointWithCoordinates
	(
		IReal x,
		IReal y,
		IReal z
	) : base
	(
		new PointWithCoordinates<IReal>(x, y, z)
	)
	{
	}
}