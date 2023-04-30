using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real.FromCollection.FromSystem;

namespace Tumbleweed.Numbers.Real.Planar;

public sealed class PlanarFromCollection : PlanarEnvelope<IReal>
{
	public PlanarFromCollection(ICollection<IReal> collection) : base
	(
		new PlanarWithValues<IReal>(
			new RealWithIndex(collection, 0),
			new RealWithIndex(collection, 1))
	)
	{
	}
}