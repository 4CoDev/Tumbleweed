using Property = Tumbleweed.Property.Output;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Output.With;

public sealed class Value : Property::Envelope<System::Object>
{
	public Value(System::Object value) : base
	(
		new Property::With.Value<System::Object>(value)
	)
	{
	}
}