using Scalar = Tumbleweed.Scalar;
using System = System;
using Object = Tumbleweed.Object;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.As;

public sealed class Type<T> : Scalar::Envelope<T>
{
	public Type(System::Object scalar) : this
	(
		new Scalar::Unpacked<System::Object>(scalar)
	)
	{
	}
	
	public Type(Scalar::Any<System::Object> scalar) : base
	(
		new Scalar::Of.Nested<T>(
			new Object::Unpacked<Scalar::Any<T>>(scalar))
	)
	{
	}
}