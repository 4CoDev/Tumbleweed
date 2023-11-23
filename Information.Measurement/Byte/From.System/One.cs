using Tumbleweed.Enumerable.Function;
using Tumbleweed.Mathematics.Boolean.FromByte.FromSystem;
using Tumbleweed.Property.Output;

namespace Tumbleweed.Information.Measurement.Byte.From.System;

public sealed class One : Enumerable.Envelope<Mathematics.Boolean.Any>
{
	public One(Any<global::System.Byte> @byte) : base
	(
		new Result<Mathematics.Boolean.Any>(
			() => Function(@byte))
	)
	{
	}

	private static IEnumerable<Mathematics.Boolean.Any> Function(Any<global::System.Byte> @byte)
	{
		for (Int32 index = 0; index < 8; index++)
			yield return new BooleanWithIndex(@byte, index);
	}
}