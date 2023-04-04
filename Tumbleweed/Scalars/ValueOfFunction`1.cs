using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Hashes;
using Tumbleweed.Scalars.Equality;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Scalars;

public sealed class ValueOfFunction<T> : IScalar<T>
{
	public ValueOfFunction(Func<T> function) : this
	(
		new FunctionFromSystem<T>(function)
	)
	{
	}
	
	public ValueOfFunction(INullaryFunction<T> function) =>
		this.function = function;
	
	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables<T>(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashOfNullable(Value).Value;

	public override String? ToString() =>
		new NullableFromNullable(Value).Value;

	public T Value => function.Invoke();

	private readonly INullaryFunction<T> function;
}