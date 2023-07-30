using Boolean = Tumbleweed.Boolean;
using Nullable = Tumbleweed.Scalar.Nullable;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Nullable.Has;

public sealed class Value : Boolean::Envelope
{
	public Value
	(
		Nullable::Any<System::Object> nullable
	) : base
	(
		new Boolean::Function.Result(
			() => nullable.HasValue)
	)
	{
	}
}