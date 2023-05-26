using Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Spatial.Real;

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