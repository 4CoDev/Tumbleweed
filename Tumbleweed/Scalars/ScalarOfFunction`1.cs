using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Hashes;
using Tumbleweed.Scalars.Equality;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Scalars;

public sealed class ScalarOfFunction<T> : IScalar<T>
{
	public ScalarOfFunction(Func<IScalar<T>> function) : this
	(
		new NullaryFromSystem<IScalar<T>>(function)
	)
	{
	}

	public ScalarOfFunction(INullaryFunction<IScalar<T>> function) =>
		this.function = function;
	
	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables<T>(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashOfNullable(Value).Value;

	public override String? ToString() =>
		new NullableFromNullable(Value).Value;
	
	public T Value => function.Invoke().Value;

	private readonly INullaryFunction<IScalar<T>> function;
}