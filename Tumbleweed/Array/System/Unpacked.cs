using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Array.System;

public sealed class Unpacked : Tumbleweed.Scalar.Immutable.Envelope<System::Array>
{
	public Unpacked(System::Object @object) : this
	(
		new Value(@object)
	)
	{
	}
	
	public Unpacked(Tumbleweed.Scalar.Immutable.Any<System::Object> scalar) : base
	(
		new Object::Unpacked<System::Array>(scalar)
	)
	{
	}
}