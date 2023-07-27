using Scalar = Tumbleweed.Scalar;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Of;

public sealed class Value : Scalar::Envelope<System::Object>
{
	public Value(System::Object value) : base
	(
		new Scalar.Of.Value<System::Object>(value)
	)
	{
	}
}