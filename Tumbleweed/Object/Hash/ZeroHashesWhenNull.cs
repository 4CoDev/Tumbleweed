using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Nullable;

namespace Tumbleweed.Object.Hash;

public sealed class ZeroHashesWhenNull : Enumerable.Envelope<Int32>
{
	public ZeroHashesWhenNull
	(
		IEnumerable<Any<System.Object>> nullables
	) : base
	(
		new Selected<Any<System.Object>, Int32>(
			nullables,
			nullable => new ZeroHashWhenNull(nullable).Value)
	)
	{
	}
}