using Tumbleweed.Enumerables;
using Tumbleweed.Nullables;

namespace Tumbleweed.Objects.Hashes;

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