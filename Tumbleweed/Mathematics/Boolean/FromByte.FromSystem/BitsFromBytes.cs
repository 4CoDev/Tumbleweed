using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable;
using System = System;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Boolean.FromByte.FromSystem;

public sealed class BitsFromBytes : Enumerable.Envelope<Any>
{
	public BitsFromBytes(IEnumerable<System::Byte> bytes) : this
	(
		new Enumerable::Item.Every.Scalar.Of.Value<System::Byte>(bytes)
	)
	{
	}
	
	public BitsFromBytes(IEnumerable<Any<System::Byte>> bytes) : base
	(
		new Concatenated<Any>(
			new Selected<Any<System::Byte>, IEnumerable<Any>>(
				bytes,
				@byte => new BitsFromByte(@byte)))
	)
	{
	}
}