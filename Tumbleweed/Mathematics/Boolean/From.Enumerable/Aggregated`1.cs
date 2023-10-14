using Tumbleweed.Mathematics.Boolean.Scalar.Value;
using Tumbleweed.Scalar.Immutable.From.Enumerable;
using BinaryFunction = Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Mathematics.Boolean.From.Enumerable;

public sealed class Aggregated<TFrom> : Envelope
{
	public Aggregated
	(
		IEnumerable<TFrom> from,
		Any seed,
		Func<Any, TFrom, Any> expression
	) : this
	(
		from,
		seed,
		new BinaryFunction.From.System
		<
			Any,
			TFrom,
			Any
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
		Any seed,
		BinaryFunction.Any<Any, TFrom, Any> expression
	) : base
	(
		new Actual(
			new Aggregated<TFrom, Any>(
				from,
				seed,
				expression))
	)
	{
	}
}