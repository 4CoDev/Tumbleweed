using Scalar = Tumbleweed.Scalar;
using System = System;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Array.System;

public sealed class Unpacked : Scalar::Envelope<System::Array>
{
	public Unpacked(System::Object @object) : this
	(
		new Scalar::Of.Value(@object)
	)
	{
	}
	
	public Unpacked(Scalar::Any<System::Object> scalar) : base
	(
		new Object::Unpacked<System::Array>(scalar)
	)
	{
	}
}