using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial;

public sealed class SpatialFromEnumerable : SpatialEnvelope<IReal>
{
	public SpatialFromEnumerable(IEnumerable<IReal> enumerable) : base
	(
		new SpatialFromCollection(
			new List<IReal>(enumerable))
	)
	{
	}
}