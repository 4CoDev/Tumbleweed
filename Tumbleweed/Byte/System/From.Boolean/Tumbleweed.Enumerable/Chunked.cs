using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Item.Every.Scalar;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Byte.System.From.Boolean.Tumbleweed.Enumerable;

public sealed class Chunked : global::Tumbleweed.Enumerable.Envelope<System::Byte>
{
	public Chunked(IEnumerable<IEnumerable<Mathematics.Boolean.Any>> bytes) : base
	(
		new Value<System::Byte>(
			new Selected<IEnumerable<Mathematics.Boolean.Any>, Any<System::Byte>>(
				bytes,
				@byte => new Linear(@byte)))
	)
	{
	}
}