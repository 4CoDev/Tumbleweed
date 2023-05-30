using Tumbleweed.Number.Real;

namespace Tumbleweed.Planar.Point.Real;

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