using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Numerics.Spatial.Coordinates;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates;

public sealed class XOfSpatials : EnumerableEnvelope<IFractional>
{
	public XOfSpatials
	(
		IEnumerable<ISpatial<IFractional>> spatials
	) : base
	(
		new XOfSpatials<IFractional>(spatials)
	)
	{
	}
}