using Tumbleweed.Mathematics.Boolean.Property.Value;
using Tumbleweed.Property.Output.Function.Result;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Mathematics.Boolean.Function.Result;

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
		new Property.Value.Actual(
			new Actual<Any>(function))
	)
	{
	}
}