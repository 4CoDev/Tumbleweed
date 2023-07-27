using Tumbleweed.Byte;

using Tumbleweed.Enumerable.With.Length.Statement;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Integer.System.Medium.With.Bits;

public sealed class New : TW.Scalar.Envelope<global::System.Int32>
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