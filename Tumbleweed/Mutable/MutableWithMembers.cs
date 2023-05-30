using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;
using Tumbleweed.Subroutine.Unary.Action;

namespace Tumbleweed.Mutable;

public sealed class MutableWithMembers<T> : IMutable<T>
{
	public MutableWithMembers
	(
		Func<T> accessor,
		Action<T> mutator
	) : this
	(
		new FunctionFromSystem<T>(accessor),
		new ActionFromSystem<T>(mutator)
	)
	{
	}

	public MutableWithMembers
	(
		IFunction<T> accessor,
		IAction<T> mutator
	) : this
	(
		new ResultOfFunction<T>(accessor),
		mutator
	)
	{
	}
	
	public MutableWithMembers
	(
		IScalar<T> accessor,
		IAction<T> mutator
	)
	{
		this.accessor = accessor;
		this.mutator = mutator;
	}

	public T Value
	{
		get => accessor.Value;
		set => mutator.InvokeWith(value);
	}
	
	private readonly IScalar<T> accessor;
	
	private readonly IAction<T> mutator;
}