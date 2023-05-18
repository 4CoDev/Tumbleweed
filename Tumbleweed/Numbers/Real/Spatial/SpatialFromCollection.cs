using Tumbleweed.Numbers.Real.FromCollection.FromSystem;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial;

public sealed class PointFromCollection : PointEnvelope<IReal>
{
	public PointFromCollection(ICollection<IReal> collection) : base
	(
		new PointWithCoordinates<IReal>(
			new RealWithIndex(collection, 0),
			new RealWithIndex(collection, 1),
			new RealWithIndex(collection, 2))
	)
	{
	}
}