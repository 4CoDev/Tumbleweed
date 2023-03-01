using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatials;

public sealed class ZOfSpatials : EnumerableEnvelope<IFractional>
{
	public ZOfSpatials(IEnumerable<ISpatial<IFractional>> spatials) : base
	(
		new SelectedByExpression<ISpatial<IFractional>, IFractional>(
			spatials,
			spatial => spatial.Z)
	)
	{
	}
}