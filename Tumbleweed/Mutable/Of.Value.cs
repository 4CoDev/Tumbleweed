using Tumbleweed.Object.String;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mutable.Of;

public sealed class MutableValue<T> : Any<T>
{
	public MutableValue(T value) =>
		Value = value;

	public override System::String ToString() =>
		new StringFromAnyObject(Value).Value.Value;

	public T Value { get; set; }
}