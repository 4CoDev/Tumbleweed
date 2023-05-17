using Tumbleweed.Enumerables;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.FromEnumerables;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class SmallestOfSpatials : SpatialEnvelope<IReal>
{
	public SmallestOfSpatials
	(
		params ISpatial<IReal>[] spatials
	) : this
	(
		new EnumerableWithElements<ISpatial<IReal>>(spatials)
	)
	{
	}
	
	public SmallestOfSpatials
	(
		IEnumerable<ISpatial<IReal>> spatials
	) : base
	(
		new AggregatedByExpression<IReal>(
			spatials,
			Expression)
	)
	{
	}

	private static ISpatial<IReal> Expression
	(
		ISpatial<IReal> smallest,
		ISpatial<IReal> number
	) =>
	(
		new SmallestOfTwoSpatials(smallest, number)
	);
}