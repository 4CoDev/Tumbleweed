using Tumbleweed._Enumerable;
using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;

namespace Tumbleweed._String.Nullable;

public sealed class NullablesFromSystem
	: EnumerableEnvelope<INullable<IString>>
{
	public NullablesFromSystem
	(
		IEnumerable<String?> nullables
	) : this
	(
		new NullablesFromSystem<String>(nullables)
	)
	{
	}
	
	public NullablesFromSystem
	(
		IEnumerable<INullable<String>> nullables
	) : base
	(
		new SelectedByExpression<INullable<String>, INullable<IString>>(
			nullables,
			nullable => new NullableFromSystem(nullable))
	)
	{
	}
}