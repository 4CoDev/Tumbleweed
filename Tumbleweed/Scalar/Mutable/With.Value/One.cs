using Tumbleweed.Object.String;
using Mutable = Tumbleweed.Scalar.Mutable;
using System = System;

namespace Tumbleweed.Scalar.Mutable.With.Value;

public sealed class One<T> : Mutable::Any<T>
{
	public One(T value) =>
		Value = value;

	public override System::String ToString() =>
		new StringFromAnyObject(Value).Value.Value;

	public T Value { get; set; }
}