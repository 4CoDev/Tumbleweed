namespace Tumbleweed.Delegates.Functions.Nullary;

public class NullaryFromSystem<TResult> : INullaryFunction<TResult>
{
	public NullaryFromSystem(Func<TResult> function) =>
		this.function = function;

	public TResult Invoke() => function.Invoke();
	
	private readonly Func<TResult> function;
}