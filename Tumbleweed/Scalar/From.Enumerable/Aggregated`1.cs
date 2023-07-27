using Tumbleweed.Scalar.Function;
using Tumbleweed.Subroutine.Function.Binary;
using BinaryFunction = Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Scalar.From.Enumerable;

public sealed class Aggregated<T> : Scalar.Envelope<T>
{
	public Aggregated
	(
		IEnumerable<T> from,
		T seed,
		Func<T, T, T> expression
	) : this
	(
		from,
		seed,
		new BinaryFunction.From.System<T, T, T>(expression)
	)
	{
	}
	
	public Aggregated
	(
		IEnumerable<T> from,
		T seed,
		Any<T, T, T> expression
	) : base
	(
		new Aggregated<T, T>(from, seed, expression)
	)
	{
	}
	
	public Aggregated
	(
		IEnumerable<T> from,
		Func<T, T, T> expression
	) : this
	(
		from,
		new BinaryFunction.From.System<T, T, T>(expression)
	)
	{
	}
	
	public Aggregated
	(
		IEnumerable<T> from,
		Any<T, T, T> expression
	) : base
	(
		new Function.Result<T>(
			() => from.Aggregate(expression.ResultWith))
	)
	{
	}
}