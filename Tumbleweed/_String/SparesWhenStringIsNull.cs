using Tumbleweed._Enumerable;
using Tumbleweed._String.Nullable;
using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;

namespace Tumbleweed._String;

public sealed class SparesWhenStringIsNull : EnumerableEnvelope<IString>
{
	public SparesWhenStringIsNull
	(
		IEnumerable<String?> nullables,
		String spare
	) : this
	(
		new NullablesFromSystem(nullables),
		new StringFromSystem(spare)
	)
	{
	}
	
	public SparesWhenStringIsNull
	(
		IEnumerable<IString?> nullables,
		IString spare
	) : this
	(
		new NullablesFromSystem<IString>(nullables),
		spare
	)
	{
	}
	
	public SparesWhenStringIsNull
	(
		IEnumerable<INullable<IString>> nullables,
		IString spare
	) : base
	(
		new SelectedByExpression<INullable<IString>, IString>(
			nullables,
			nullable => Expression(nullable, spare))
	)
	{
	}

	private static IString Expression
	(
		INullable<IString> nullable,
		IString spare
	) =>
	(
		new SpareWhenStringIsNull(nullable, spare)
	);
}