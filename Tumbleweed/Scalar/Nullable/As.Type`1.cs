using Nullable = Tumbleweed.Scalar.Nullable;
using System = System;
using Object = Tumbleweed.Object;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Nullable.As;

public sealed class Type<T> : Nullable::Envelope<T>
{
	public Type(Nullable::Any<System::Object> origin) : base
	(
		new Nullable::With.Members<T>(
			new Object::Unpacked<T>(origin),
			new Nullable::Has.Value(origin))
	)
	{
	}
}