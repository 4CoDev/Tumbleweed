using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Property = Tumbleweed.Property.Output;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using System = System;
using Equality = Tumbleweed.Property.Output.Equality;

namespace Tumbleweed.Property.Output.Function.Result;

public sealed class Actual<T> : Property::Any<T>
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
		new StringFromAnyObject(Value).Value.AsSystem;

	public T Value =>
		function.Result;

	private readonly Function::Any<T> function;
}