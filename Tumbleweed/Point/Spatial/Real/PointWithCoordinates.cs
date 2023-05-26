using Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Spatial.Real;

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