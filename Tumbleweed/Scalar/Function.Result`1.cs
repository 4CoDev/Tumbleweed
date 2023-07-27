using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Scalar.Equality.Of.Two;
using Tumbleweed.Subroutine.Function.Nullary.From;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Function;

public sealed class Result<T> : Scalar.Any<T>
{
	public Result(Func<T> function) : this
	(
		new System<T>(function)
	)
	{
	}
	
	public Result(NullaryFunction.Any<T> function) =>
		this.function = function;
	
	public override System::Boolean Equals(System::Object? @object) =>
		new Nullables<T>(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashOfNullable(Value).Value;

	public override System::String? ToString() =>
		new StringFromAnyObject(Value).Value.Value;

	public T Value =>
		function.Result;

	private readonly NullaryFunction.Any<T> function;
}