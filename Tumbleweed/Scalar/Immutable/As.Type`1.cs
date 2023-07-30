using Tumbleweed.Scalar.Immutable.Nested;
using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;
using Object = Tumbleweed.Object;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.As;

public sealed class Type<T> : Immutable::Envelope<T>
{
	public Type
	(
		Immutable::Any<System::Object> scalar
	) : base
	(
		new Value<T>(
			new Object::Unpacked<Immutable::Any<T>>(scalar))
	)
	{
	}
}