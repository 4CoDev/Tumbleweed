using Tumbleweed._Object.Hash;
using Tumbleweed._Object.String;
using Tumbleweed.Scalar.Equality;
using Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Scalar;

public sealed class ResultOfFunction<T> : IScalar<T>
{
	public ResultOfFunction(Func<T> function) : this
	(
		new FunctionFromSystem<T>(function)
	)
	{
	}
	
	public ResultOfFunction(IFunction<T> function) =>
		this.function = function;
	
	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables<T>(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashOfNullable(Value).Value;

	public override String? ToString() =>
		new StringFromNullableObject(Value).Value.Value;

	public T Value =>
		function.Result;

	private readonly IFunction<T> function;
}