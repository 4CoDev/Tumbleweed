using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Object.Casted.Convertee;

public sealed class Object<T> : Property::Envelope<T>
{
	public Object(System::Object convertee) : this
	(
		new Property::With.Value.One
			<System::Object>
			(convertee)
	)
	{
	}
	
	public Object
	(
		Property::Any<System::Object> property
	) : base
	(
		new Property::Function.Result.Actual<T>(
			() => (T) property.Value)
	)
	{
	}
}