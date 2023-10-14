using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Byte.From.System;

public sealed class Multiple : Enumerable.Envelope<IEnumerable<Mathematics.Boolean.Any>>
{
	public Multiple(IEnumerable<global::System.Byte> bytes) : this
	(
		new Enumerable::Item.Every.Scalar.Of.Value<global::System.Byte>(bytes)
	)
	{
	}
	
	public Multiple(IEnumerable<Any<global::System.Byte>> bytes) : base
	(
		new Selected<Any<global::System.Byte>, IEnumerable<Mathematics.Boolean.Any>>(
			bytes,
			@byte => new One(@byte))
	)
	{
	}
}