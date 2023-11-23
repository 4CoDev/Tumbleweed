using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Option = Tumbleweed.Property.Option;
using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Property.Option.With.Member.Definition;

public sealed class One<T> : Option::Any<T>
{
	public One(T value, System::Boolean hasValue) : this
	(
		value,
		new One(hasValue)
	)
	{
	}
	
	public One(T value, Any hasValue) : this
	(
		new Property::With.Value.One<T>(value),
		hasValue
	)
	{
	}
	
	public One
	(
		Property::Any<T> value,
		Any hasValue
	)
	{
		this.value = value;
		HasValue = hasValue;
	}

	public T Value => value.Value;

	private readonly Property::Any<T> value;

	public Any HasValue { get; }
}