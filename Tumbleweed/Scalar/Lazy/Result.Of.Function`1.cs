using Tumbleweed.Scalar.Function;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Lazy.Result.Of;

public sealed class Function<T> : Envelope<T>
{
	public Function(Func<T> function) : this
	(
		new System<T>(function)
	)
	{
	}
	
	public Function(Subroutine.Function.Nullary.Any<T> function) : base
	(
		new OfValue<T>(
			new Function.Result<T>(function))
	)
	{
	}
}