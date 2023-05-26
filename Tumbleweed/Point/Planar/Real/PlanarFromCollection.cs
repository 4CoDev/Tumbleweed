using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.FromCollection.FromSystem;

namespace Tumbleweed.Point.Planar.Real;

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