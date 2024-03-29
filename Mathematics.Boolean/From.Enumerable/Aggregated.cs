using Tumbleweed.Mathematics.Boolean.Property.Value;
using BinaryFunction = Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Mathematics.Boolean.From.Enumerable;

public sealed class Aggregated
	: Envelope
{
	public Aggregated
	(
		IEnumerable<Any> from,
		Func<Any, Any, Any> expression
	) : this
	(
		from,
		new BinaryFunction.From.System
		<
			Any,
			Any,
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
		IEnumerable<Any> from,
		BinaryFunction.Any<Any, Any, Any> expression
	) : base
	(
		new Actual(
			new Tumbleweed.Property.Output.From.Enumerable.Aggregated<Any>(
				from,
				expression))
	)
	{
	}
}