using Tumbleweed._Enumerable;
using Tumbleweed.Nullable;

namespace Tumbleweed._Object.Hash;

public sealed class ZeroHashesWhenNull : EnumerableEnvelope<Int32>
{
	public ZeroHashesWhenNull
	(
		IEnumerable<INullable<Object>> nullables
	) : base
	(
		new SelectedByExpression<INullable<Object>, Int32>(
			nullables,
			nullable => new ZeroHashWhenNull(nullable).Value)
	)
	{
	}
}