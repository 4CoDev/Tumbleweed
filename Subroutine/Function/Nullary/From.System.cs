using Function = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Function.Nullary.From;

public class System<ResultType> : Function::Any<ResultType>
{
	public System(Func<ResultType> function) =>
		this.function = function;

	public ResultType Result =>
		function.Invoke();
	
	private readonly Func<ResultType> function;
}