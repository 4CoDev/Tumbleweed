// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Function.Binary.From;

public sealed class System<T1, T2, Result>
	: Any<T1, T2, Result>
{
	public System
	(
		Func<T1, T2, Result> function
	)
	{
		this.function = function;
	}


	public Result ResultWith(T1 parameter1, T2 parameter2) =>
		function.Invoke(parameter1, parameter2);

	private readonly Func<T1, T2, Result> function;
}