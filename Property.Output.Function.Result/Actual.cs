using Property = Tumbleweed.Property.Output;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Property.Output.Function.Result;

public sealed class Actual<T> : Property::Any<T>
{
	public Actual(Func<T> function) : this
	(
		new Function::From.System<T>(function)
	)
	{
	}
	
	public Actual(Function::Any<T> function) =>
		this.function = function;

	public T Value =>
		function.Result;

	private readonly Function::Any<T> function;
}