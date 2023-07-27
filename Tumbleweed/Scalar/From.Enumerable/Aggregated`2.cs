using Tumbleweed.Scalar.Function;
using Tumbleweed.Subroutine.Function.Binary;
using BinaryFunction = Tumbleweed.Subroutine.Function.Binary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.From.Enumerable;

public sealed class Aggregated<TFrom, TAccumulate>
	: Scalar.Envelope<TAccumulate>
{
	public Aggregated
	(
		IEnumerable<TFrom> from,
		TAccumulate seed,
		Func<TAccumulate, TFrom, TAccumulate> expression
	) : this
	(
		from,
		seed,
		new BinaryFunction.From.System
		<
			TAccumulate,
			TFrom,
			TAccumulate
		>
		(
			expression
		)
	)
	{
	}
	
	public Aggregated
	(
		IEnumerable<TFrom> from,
		TAccumulate seed,
		Any<TAccumulate, TFrom, TAccumulate> expression
	) : base
	(
		new Function.Result<TAccumulate>(
			() => from.Aggregate(seed, expression.ResultWith))
	)
	{
	}
}