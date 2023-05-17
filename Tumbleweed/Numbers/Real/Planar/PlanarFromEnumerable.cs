using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar;

public sealed class PlanarFromEnumerable : PlanarEnvelope<IReal>
{
	public PlanarFromEnumerable(IEnumerable<IReal> enumerable) : base
	(
		new PlanarFromCollection(
			new List<IReal>(enumerable))
	)
	{
	}
}