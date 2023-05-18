using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar;

public sealed class PointFromEnumerable : PointEnvelope<IReal>
{
	public PointFromEnumerable(IEnumerable<IReal> enumerable) : base
	(
		new PointFromCollection(
			new List<IReal>(enumerable))
	)
	{
	}
}