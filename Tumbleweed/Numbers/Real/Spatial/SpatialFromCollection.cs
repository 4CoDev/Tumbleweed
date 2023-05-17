using Tumbleweed.Numbers.Real.FromCollection.FromSystem;
using Tumbleweed.Points.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial;

public sealed class SpatialFromCollection : SpatialEnvelope<IReal>
{
	public SpatialFromCollection(ICollection<IReal> collection) : base
	(
		new SpatialWithCoordinates<IReal>(
			new RealWithIndex(collection, 0),
			new RealWithIndex(collection, 1),
			new RealWithIndex(collection, 2))
	)
	{
	}
}