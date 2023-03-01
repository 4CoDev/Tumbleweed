using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatials;

public sealed class YOfSpatials : EnumerableEnvelope<IFractional>
{
	public YOfSpatials(IEnumerable<ISpatial<IFractional>> spatials) : base
	(
		new SelectedByExpression<ISpatial<IFractional>, IFractional>(
			spatials,
			spatial => spatial.Y)
	)
	{
	}
}