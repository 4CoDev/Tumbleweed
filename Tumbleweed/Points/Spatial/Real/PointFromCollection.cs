using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.FromCollection.FromSystem;

namespace Tumbleweed.Points.Spatial.Real;

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