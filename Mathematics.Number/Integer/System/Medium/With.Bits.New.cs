using Tumbleweed.Enumerable.Requirement.Length;
using Tumbleweed.Information.Measurement.Byte.Multiple.From.Bit.Enumerable;
using Tumbleweed.Property.Output;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.With.Bits;

public sealed class New : Envelope<global::System.Int32>
{
	public New(IEnumerable<Boolean.Any> bits) : base
	(
		new Mathematics.Number.Integer.System.Medium.From.Bytes.Tumbleweed(
			new Linear(
				new System<Boolean.Any>(bits, 32)))
	)
	{
	}
}