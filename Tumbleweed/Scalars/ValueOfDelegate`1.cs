using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Hashes;
using Tumbleweed.Strings.FromObjects;

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
		new Equality.EqualityOfTwoNullables<T>(this, @object).State;

	public override int GetHashCode() =>
		new CodeOfNullable(Value).Value;

	public override string? ToString() =>
		new NullableFromNullable(Value).Value;

	private readonly INullaryFunction<T> function;
}