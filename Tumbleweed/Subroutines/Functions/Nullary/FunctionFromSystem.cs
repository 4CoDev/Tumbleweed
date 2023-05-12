namespace Tumbleweed.Subroutines.Functions.Nullary;

public class FunctionFromSystem<TResult> : IFunction<TResult>
{
	public FunctionFromSystem(Func<TResult> function) =>
		this.function = function;

	public TResult Result => function.Invoke();
	
	private readonly Func<TResult> function;
}