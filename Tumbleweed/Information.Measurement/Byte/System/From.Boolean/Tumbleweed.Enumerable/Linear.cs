using Tumbleweed.Information.Measurement.Byte.One.From.Bit.Collection;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Information.Measurement.Byte.System.From.Boolean.Tumbleweed.Enumerable;

public sealed class Linear : Envelope<System::Byte>
{
	public Linear(IEnumerable<Mathematics.Boolean.Any> bits) : base
	(
		new Byte.System.From.Boolean.System.Collection(
			new global::Tumbleweed.Mathematics.Boolean.System.From.Tumbleweed.Multiple(
				new Actual(bits)))
	)
	{
	}
}