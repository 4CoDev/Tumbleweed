using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Scalar.Immutable;

public sealed class Unboxed<T> : Immutable::Envelope<T>
{
	public Unboxed(System::Object @object) : this
	(
		new Immutable::With.Value(@object)
	)
	{
	}
	
	public Unboxed
	(
		Immutable::Any<System::Object> scalar
	) : base
	(
		new Immutable::Nested.Value<T>(
			new Object::Unpacked<Immutable::Any<T>>(scalar))
	)
	{
	}
}