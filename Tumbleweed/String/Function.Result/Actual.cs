using Tumbleweed.Property.Output.Function.Result;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.String.Function.Result;

public sealed class Actual : Envelope
{
	public Actual(Func<Any> function) : this
	(
		new NullaryFunction.From.System<Any>(function)
	)
	{
	}
	
	public Actual(NullaryFunction.Any<Any> function) : base
	(
		new String.Property.Value.Actual(
			new Actual<Any>(function))
	)
	{
	}
}