using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.FromEnumerables;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class LargestOfSpatials : SpatialEnvelope<IReal>
{
	public LargestOfSpatials
	(
		params ISpatial<IReal>[] spatials
	) : this
	(
		new EnumerableWithElements<ISpatial<IReal>>(spatials)
	)
	{
	}
	
	public LargestOfSpatials
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
		new LargestOfTwoSpatials(smallest, number)
	);
}