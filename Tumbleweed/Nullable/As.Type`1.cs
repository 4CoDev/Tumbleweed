using Tumbleweed.Scalar;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Nullable.As;

public sealed class Type<T> : Nullable.Envelope<T>
{
	public Type(Nullable.Any<System::Object> origin) : base
	(
		new With.Members<T>(
			new Object.Unpacked<T>(
				new Nullable.Value(origin)),
			new Nullable.Has.Value(origin))
	)
	{
	}
}