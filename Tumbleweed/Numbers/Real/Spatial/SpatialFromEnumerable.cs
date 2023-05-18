using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial;

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