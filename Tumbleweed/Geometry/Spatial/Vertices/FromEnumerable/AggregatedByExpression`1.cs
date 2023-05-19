using Tumbleweed.Points.Spatial;
using Tumbleweed.Subroutines.Functions.Binary;

namespace Tumbleweed.Geometry.Spatial.Vertices.FromEnumerable;

public sealed class AggregatedByExpression<T> : VertexEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<T> from,
		IVertex seed,
		Func<IVertex, T, IVertex> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<IVertex, T, IVertex>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<T> from,
		IVertex seed,
		IFunction<IVertex, T, IVertex> 
		expression
	) : base
	(
		new VertexOfScalar(
			new Scalars.FromEnumerable.AggregatedByExpression<T, IVertex>(
					from,
					seed,
					expression))
	)
	{
	}
}