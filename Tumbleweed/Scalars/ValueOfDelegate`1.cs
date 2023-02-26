using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.HashCodes;
using Tumbleweed.Strings;

namespace Tumbleweed.Scalars;

public sealed class ValueOfDelegate<T> : IScalar<T>
{
	public ValueOfDelegate(Func<T> function) : this
	(
		new NullaryFromSystem<T>(function)
	)
	{
	}
	
	public ValueOfDelegate(INullaryFunction<T> function) =>
		this.function = function;

	public T Value => function.Invoke();

	public override bool Equals(object? @object) =>
		new Equality.TwoNullableScalars<T>(this, @object).State;

	public override int GetHashCode() =>
		new HashCodeOfObject(function).Value;

	public override string? ToString() =>
		new NullableFromObject(function).Value;

	private readonly INullaryFunction<T> function;
}