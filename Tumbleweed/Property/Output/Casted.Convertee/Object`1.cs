using Property = Tumbleweed.Property.Output;
using System = System;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Property.Output.Casted.Convertee;

public sealed class Object<T> : Property::Envelope<T>
{
	public Object(System::Object convertee) : this
	(
		new Property::With.Value(convertee)
	)
	{
	}
	
	public Object
	(
		Property::Any<System::Object> convertee
	) : base
	(
		new Property::Nested.Value<T>(
			new Object::Casted.Convertee.Object
				<Property::Any<T>>
				(convertee))
	)
	{
	}
}