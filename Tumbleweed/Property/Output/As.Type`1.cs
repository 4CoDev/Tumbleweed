using Tumbleweed.Property.Output.Nested;
using Property = Tumbleweed.Property.Output;
using System = System;
using Object = Tumbleweed.Object;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Output.As;

public sealed class Type<T> : Property::Envelope<T>
{
	public Type
	(
		Property::Any<System::Object> property
	) : base
	(
		new Value<T>(
			new Object::Casted.Convertee.Object
				<Property::Any<T>>
				(property))
	)
	{
	}
}