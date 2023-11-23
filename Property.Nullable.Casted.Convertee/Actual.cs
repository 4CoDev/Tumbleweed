using Tumbleweed.Object.Casted.Convertee;
using Nullable = Tumbleweed.Property.Nullable;
using System = System;
using Object = Tumbleweed.Object;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Nullable.As;

public sealed class Actual<T> : Nullable::Envelope<T>
{
	public Actual(Nullable::Any<System::Object> origin) : base
	(
		new Nullable::With.Member.Definition.One<T>(
			new Object<T>(origin),
			new Nullable::Has.Value(origin))
	)
	{
	}
}