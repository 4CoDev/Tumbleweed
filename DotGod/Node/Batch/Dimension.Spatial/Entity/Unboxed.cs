using DotGod.Node.Batch.Dimension.Spatial.Entity.Property.Value;
using Tumbleweed.Object.Casted.Convertee;
using System = System;
using Property = Tumbleweed.Property.Output;
using Object = Tumbleweed.Object;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity;

public sealed class Unboxed : Envelope
{
	public Unboxed(System::Object @object) : this
	(
		new Property::With.Value<System::Object>(@object)
	)
	{
	}
	
	public Unboxed(Property::Any<System::Object> property) : base
	(
		new One(
			new Object<Any>(property))
	)
	{
	}
}