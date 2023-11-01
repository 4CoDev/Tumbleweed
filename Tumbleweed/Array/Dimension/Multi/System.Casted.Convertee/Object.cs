using Tumbleweed.Object.Casted.Convertee;
using Tumbleweed.Property.Output.With;
using System = System;

namespace Tumbleweed.Array.Dimension.Multi.System.Casted.Convertee;

public sealed class Object : Tumbleweed.Property.Output.Envelope<System::Array>
{
	public Object(System::Object @object) : this
	(
		new Value(@object)
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