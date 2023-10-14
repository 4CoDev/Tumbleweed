using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Function.Result;

using Nullable = Tumbleweed.Scalar.Nullable;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Nullable.Has;

public sealed class Value : Envelope
{
	public Value
	(
		Nullable::Any<System::Object> nullable
	) : base
	(
		new Actual(
			() => nullable.HasValue)
	)
	{
	}
}