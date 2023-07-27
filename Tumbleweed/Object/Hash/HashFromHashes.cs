using Tumbleweed.Scalar;
using Tumbleweed.Scalar.From.Enumerable;

namespace Tumbleweed.Object.Hash;

public sealed class HashFromHashes : Envelope<Int32>
{
	public HashFromHashes(IEnumerable<Int32> hashes) : base
	(
		new Aggregated<Int32>(
			hashes,
			17,
			Expression)
	)
	{
	}

	private static Int32 Expression(Int32 total, Int32 hash) =>
		total * 31 + hash;
}