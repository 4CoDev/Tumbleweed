using Tumbleweed.Subroutines.Functions.Binary;

namespace Tumbleweed.Geometry.Spatial.Vertices.FromEnumerable;

public sealed class AggregatedByExpression : VertexEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<IVertex> from,
		IVertex seed,
		Func<IVertex, IVertex, IVertex> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<IVertex, IVertex, IVertex>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<IVertex> from,
		IVertex seed,
		IFunction<IVertex, IVertex, IVertex> expression
	) : base
	(
		new VertexOfScalar(
			new Scalars.FromEnumerable.AggregatedByExpression<IVertex>(
				from,
				seed,
				expression))
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<IVertex> from,
		Func<IVertex, IVertex, IVertex> expression
	) : this
	(
		from,
		new FunctionFromSystem<IVertex, IVertex, IVertex>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<IVertex> from,
		IFunction<IVertex, IVertex, IVertex> expression
	) : base
	(
		new VertexOfScalar(
			new Scalars.FromEnumerable.AggregatedByExpression<IVertex>(
				from,
				expression))
	)
	{
	}
}