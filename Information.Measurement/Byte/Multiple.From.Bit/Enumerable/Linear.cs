using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Chunked.By.Length;
using Tumbleweed.Mathematics.Boolean.FromByte.FromSystem;

namespace Tumbleweed.Information.Measurement.Byte.Multiple.From.Bit.Enumerable;

public sealed class Linear : Envelope<IEnumerable<Mathematics.Boolean.Any>>
{
	public Linear(IEnumerable<Mathematics.Boolean.Any> bits) : base
	(
		new Chunked(
			new System<Mathematics.Boolean.Any>(bits, new NumberOfBits()))
	)
	{
	}
}