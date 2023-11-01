using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Function.Result;

using Nullable = Tumbleweed.Property.Nullable;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Nullable.Has;

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