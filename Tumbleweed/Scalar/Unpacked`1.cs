using Scalar = Tumbleweed.Scalar;
using System = System;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Scalar;

public sealed class Unpacked<T> : Scalar::Envelope<T>
{
	public Unpacked(System::Object @object) : this
	(
		new Scalar.Of.Value(@object)
	)
	{
	}
	
	public Unpacked(Scalar::Any<System::Object> scalar) : base
	(
		new Scalar::Of.Nested<T>(
			new Object::Unpacked<Scalar::Any<T>>(scalar))
	)
	{
	}
}