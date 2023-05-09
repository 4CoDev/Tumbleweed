using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class WordsWhenNulls : EnumerableEnvelope<String>
{
	public WordsWhenNulls
	(
		IEnumerable<String?> nullables,
		String word
	) : this
	(
		nullables,
		new ScalarValue<String>(word)
	)
	{
	}
	
	public WordsWhenNulls
	(
		IEnumerable<String?> nullables,
		IScalar<String> word
	) : base
	(
		new SelectedByExpression<String?, String>(
			nullables,
			nullable => new SpareWhenNull(nullable, word).Value)
	)
	{
	}
}