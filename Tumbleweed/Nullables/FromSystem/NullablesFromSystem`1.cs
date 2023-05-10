using Tumbleweed.Enumerables;

namespace Tumbleweed.Nullables.FromSystem;

public sealed class NullablesFromSystem<T> :
	EnumerableEnvelope<INullable<T>>
	where T : notnull
{
	public NullablesFromSystem(IEnumerable<T?> nullables) : base
	(
		new SelectedByExpression<T?, INullable<T>>(
			nullables,
			nullable => new NullableFromSystem<T>(nullable))
	)
	{
	}
}