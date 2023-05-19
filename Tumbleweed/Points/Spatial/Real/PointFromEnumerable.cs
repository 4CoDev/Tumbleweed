using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Spatial.Real;

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