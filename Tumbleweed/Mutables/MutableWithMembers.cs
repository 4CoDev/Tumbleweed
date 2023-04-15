using Tumbleweed.Delegates.Actions.Unary;
using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Mutables;

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
		INullaryFunction<T> accessor,
		IUnaryAction<T> mutator
	) : this
	(
		new ValueOfFunction<T>(accessor),
		mutator
	)
	{
	}
	
	public MutableWithMembers
	(
		IScalar<T> accessor,
		IUnaryAction<T> mutator
	)
	{
		this.accessor = accessor;
		this.mutator = mutator;
	}

	public T Variable
	{
		get => accessor.Value;
		set => mutator.Invoke(value);
	}
	
	private readonly IScalar<T> accessor;
	
	private readonly IUnaryAction<T> mutator;
}