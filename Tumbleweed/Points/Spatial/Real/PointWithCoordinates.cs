using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Spatial.Real;

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