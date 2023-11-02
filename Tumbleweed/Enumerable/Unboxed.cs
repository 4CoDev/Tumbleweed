using Tumbleweed.Object.Casted.Convertee;
using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Property = Tumbleweed.Property.Output;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Enumerable;

public sealed class Unboxed : Enumerable::Envelope
{
	public Unboxed(System::Object @object) : this
	(
		new Property::With.Value.One
			<System::Object>
			(@object)
	)
	{
	}
	
	public Unboxed(Property::Any<System::Object> @object) : base
	(
		new Enumerable::Property.Value(
			new Object<System::Collections.IEnumerable>(@object))
	)
	{
	}
}