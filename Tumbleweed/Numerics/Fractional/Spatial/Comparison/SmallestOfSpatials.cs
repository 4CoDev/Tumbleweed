using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Numerics.Spatial.FromEnumerables;

namespace Tumbleweed.Numerics.Fractional.Spatial.Comparison;

public sealed class SmallestOfSpatials : SpatialEnvelope<IFractional>
{
	public SmallestOfSpatials
	(
		params ISpatial<IFractional>[] spatials
	) : this
	(
		new EnumerableWithElements<ISpatial<IFractional>>(spatials)
	)
	{
	}
	
	public SmallestOfSpatials
	(
		IEnumerable<ISpatial<IFractional>> spatials
	) : base
	(
		new AggregatedByExpression<IFractional>(
			spatials,
			Expression)
	)
	{
	}

	private static ISpatial<IFractional> Expression
	(
		ISpatial<IFractional> smallest,
		ISpatial<IFractional> number
	) =>
	(
		new SmallestOfTwoSpatials(smallest, number)
	);
}