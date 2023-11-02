using Tumbleweed.Object.Casted.Convertee;
using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Array.Dimension.Multi.System.Casted.Convertee;

public sealed class Object : Tumbleweed.Property.Output.Envelope<System::Array>
{
	public Object(System::Object @object) : this
	(
		new Property::With.Value.One<System::Object>(@object)
	)
	{
	}
	
	public Object(Tumbleweed.Property.Output.Any<System::Object> property) : base
	(
		new Object<System::Array>(property)
	)
	{
	}
}