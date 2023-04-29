using Tumbleweed.Numerics.Fractional.FromCollection.FromSystem;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Fractional.Planar;

public sealed class PlanarFromCollection : PlanarEnvelope<IFractional>
{
	public PlanarFromCollection(ICollection<IFractional> collection) : base
	(
		new PlanarWithValues<IFractional>(
			new FractionalWithIndex(collection, 0),
			new FractionalWithIndex(collection, 1))
	)
	{
	}
}