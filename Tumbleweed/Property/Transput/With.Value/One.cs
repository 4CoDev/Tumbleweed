using Tumbleweed.Object.String;
using Property = Tumbleweed.Property.Transput;
using System = System;

namespace Tumbleweed.Property.Transput.With.Value;

public sealed class One<T> : Property::Any<T>
{
	public One(T value) =>
		Value = value;

	public override System::String ToString() =>
		new StringFromAnyObject(Value).Value.AsSystem;

	public T Value { get; set; }
}