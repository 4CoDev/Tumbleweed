using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Objects.Hashes;

public sealed class HashFromHashes : ScalarEnvelope<Int32>
{
	public HashFromHashes(IEnumerable<Int32> hashes) : base
	(
		new AggregatedByExpression<Int32>(
			hashes,
			17,
			Expression)
	)
	{
	}

	private static Int32 Expression(Int32 total, Int32 hash) =>
		total * 31 + hash;
}