using Tumbleweed.Numbers.Real.FromCollection.FromSystem;
using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar;

public sealed class PointFromCollection : PointEnvelope<IReal>
{
	public PointFromCollection(ICollection<IReal> collection) : base
	(
		new PointWithCoordinates<IReal>(
			new RealWithIndex(collection, 0),
			new RealWithIndex(collection, 1))
	)
	{
	}
}