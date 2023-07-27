using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Enumerable;

public sealed class Unpacked : Enumerable::Envelope
{
	public Unpacked(System::Object @object) : this
	(
		new Scalar::Of.Value(@object)
	)
	{
	}
	
	public Unpacked(Scalar::Any<System::Object> @object) : base
	(
		new Enumerable::Scalar.Value(
			new Object::Unpacked<System::Collections.IEnumerable>(@object))
	)
	{
	}
}