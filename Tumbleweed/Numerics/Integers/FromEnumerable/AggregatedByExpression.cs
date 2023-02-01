using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Integers.FromEnumerable;

public sealed class AggregatedByExpression<TFrom> : IntegerEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IInteger seed,
		Func<IInteger, TFrom, IInteger> func
	) : base
	(
		new IntegerOfScalar(
			new AggregatedByExpression<TFrom, IInteger>(from, seed, func))
	)
	{
	}
}