using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.With;

public sealed class Value : Immutable::Envelope<System::Object>
{
	public Value(System::Object value) : base
	(
		new Immutable::With.Value<System::Object>(value)
	)
	{
	}
}