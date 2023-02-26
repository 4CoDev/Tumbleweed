using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.HashCodes;
using Tumbleweed.Strings;

namespace Tumbleweed.Scalars;

public sealed class ScalarOfDelegate<T> : IScalar<T>
{
	public ScalarOfDelegate(Func<IScalar<T>> function) : this
	(
		new NullaryFromSystem<IScalar<T>>(function)
	)
	{
	}

	public ScalarOfDelegate(INullaryFunction<IScalar<T>> function) =>
		this.function = function;
	
	public T Value => function.Invoke().Value;
	
	public override bool Equals(object? @object) =>
		new Equality.TwoNullableScalars<T>(this, @object).State;

	public override int GetHashCode() =>
		new HashCodeOfObject(function).Value;

	public override string? ToString() =>
		new NullableFromObject(function).Value;

	private readonly INullaryFunction<IScalar<T>> function;
}