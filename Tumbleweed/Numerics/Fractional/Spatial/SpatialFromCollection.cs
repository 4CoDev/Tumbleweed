using Tumbleweed.Numerics.Fractional.FromCollection.FromSystem;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial;

public sealed class SpatialFromCollection : SpatialEnvelope<IFractional>
{
	public SpatialFromCollection(ICollection<IFractional> collection) : base
	(
		new SpatialWithCoordinates<IFractional>(
			new FractionalWithIndex(collection, 0),
			new FractionalWithIndex(collection, 1),
			new FractionalWithIndex(collection, 2))
	)
	{
	}
}