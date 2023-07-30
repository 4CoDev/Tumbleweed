using Tumbleweed.Byte;
using Tumbleweed.Enumerable.With.Length.Statement;
using Tumbleweed.Scalar.Immutable;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Integer.System.Medium.With.Bits;

public sealed class New : Envelope<global::System.Int32>
{
	public New(IEnumerable<Boolean.Any> bits) : base
	(
		new Medium.From.Bytes.Tumbleweed(
			new BytesFromBits(
				new System<Boolean.Any>(bits, 32)))
	)
	{
	}
}