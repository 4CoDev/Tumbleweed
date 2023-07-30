using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Function.Binary.From;

public sealed class System<T1, T2, TResult> : Any<T1, T2, TResult>
{
	public System
	(
		Func<T1, T2, TResult> function
	) : this
	(
		new Value<Func<T1, T2, TResult>>(function)
	)
	{
	}
	
	public System
	(
		Any<Func<T1, T2, TResult>> function
	)
	{
		this.function = function;
	}


	public TResult ResultWith(T1 parameter1, T2 parameter2) =>
		function.Value.Invoke(parameter1, parameter2);

	private readonly Any<Func<T1, T2, TResult>> function;
}