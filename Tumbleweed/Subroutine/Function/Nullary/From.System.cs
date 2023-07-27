// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Function.Nullary.From;

public class System<TResult> : Nullary.Any<TResult>
{
	public System(Func<TResult> function) =>
		this.function = function;

	public TResult Result =>
		function.Invoke();
	
	private readonly Func<TResult> function;
}