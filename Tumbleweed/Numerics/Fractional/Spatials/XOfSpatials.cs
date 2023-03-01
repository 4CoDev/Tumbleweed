using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatials;

public sealed class XOfSpatials : EnumerableEnvelope<IFractional>
{
	public XOfSpatials(IEnumerable<ISpatial<IFractional>> spatials) : base
	(
		new SelectedByExpression<ISpatial<IFractional>, IFractional>(
			spatials,
			spatial => spatial.X)
	)
	{
	}
}