namespace Tumbleweed.Delegates.Functions.Nullary;

public class FunctionFromSystem<TResult> : INullaryFunction<TResult>
{
	public FunctionFromSystem(Func<TResult> function) =>
		this.function = function;

	public TResult Invoke() => function.Invoke();
	
	private readonly Func<TResult> function;
}