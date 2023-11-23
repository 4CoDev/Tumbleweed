using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Subroutine.Function.Nullary;

public abstract class Envelope<T> : Function::Any<T>
{
	protected Envelope(Function::Any<T> function) =>
		this.function = function;

	public T Result =>
		function.Result;
	
	private readonly Function::Any<T> function;
}