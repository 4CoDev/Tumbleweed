using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Object;

public sealed class Unpacked<T> : Scalar::Envelope<T>
{
	public Unpacked(System::Object @object) : this
	(
		new Scalar::Of.Value(@object)
	)
	{
	}
	
	public Unpacked(Scalar::Any<System::Object> scalar) : base
	(
		new Scalar::Function.Result<T>(
			() => (T) scalar.Value)
	)
	{
	}
}