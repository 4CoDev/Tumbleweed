using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Scalar.Immutable.Casted.Convertee;

public sealed class Object<T> : Immutable::Envelope<T>
{
	public Object(System::Object convertee) : this
	(
		new Immutable::With.Value(convertee)
	)
	{
	}
	
	public Object
	(
		Immutable::Any<System::Object> convertee
	) : base
	(
		new Immutable::Nested.Value<T>(
			new Object::Casted.Convertee.Object
				<Immutable::Any<T>>
				(convertee))
	)
	{
	}
}