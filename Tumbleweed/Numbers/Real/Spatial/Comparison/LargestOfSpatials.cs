using Tumbleweed.Enumerables;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.FromEnumerables;

namespace Tumbleweed.Numbers.Real.Spatial.Comparison;

public sealed class LargestOfPoints : PointEnvelope<IReal>
{
	public LargestOfPoints
	(
		params IPoint<IReal>[] spatials
	) : this
	(
		new EnumerableWithElements<IPoint<IReal>>(spatials)
	)
	{
	}
	
	public LargestOfPoints
	(
		IEnumerable<IPoint<IReal>> spatials
	) : base
	(
		new AggregatedByExpression<IReal>(
			spatials,
			Expression)
	)
	{
	}

	private static IPoint<IReal> Expression
	(
		IPoint<IReal> smallest,
		IPoint<IReal> number
	) =>
	(
		new LargestOfTwoPoints(smallest, number)
	);
}