using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Hashes;
using Tumbleweed.Scalars.Equality;
using Tumbleweed.Strings.FromObjects;

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
	
	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables<T>(this, @object).State;

	public override Int32 GetHashCode() =>
		new CodeOfNullable(Value).Value;

	public override String? ToString() =>
		new NullableFromNullable(Value).Value;

	private readonly INullaryFunction<IScalar<T>> function;
}