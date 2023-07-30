using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Immutable = Tumbleweed.Scalar.Immutable;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using System = System;
using Equality = Tumbleweed.Scalar.Immutable.Equality;

namespace Tumbleweed.Scalar.Immutable.Function.Result;

public sealed class Actual<T> : Immutable::Any<T>
{
	public Actual(Func<T> function) : this
	(
		new Function::From.System<T>(function)
	)
	{
	}
	
	public Actual(Function::Any<T> function) =>
		this.function = function;
	
	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		new Equality::Of.Two.Nullable<T>(this, @object).State
	);

	public override System::Int32 GetHashCode() =>
		new HashOfNullable(Value).Value;

	public override System::String ToString() =>
		new StringFromAnyObject(Value).Value.Value;

	public T Value =>
		function.Result;

	private readonly Function::Any<T> function;
}