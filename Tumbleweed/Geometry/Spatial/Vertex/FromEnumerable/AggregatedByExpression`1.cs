using Tumbleweed.Scalar.FromEnumerable;
using Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Geometry.Spatial.Vertex.FromEnumerable;

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
			new AggregatedByExpression<T, IVertex>(
					from,
					seed,
					expression))
	)
	{
	}
}