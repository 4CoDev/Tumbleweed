using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class WordsWhenNulls : EnumerableEnvelope<string>
{
	public WordsWhenNulls
	(
		IEnumerable<string?> nullables,
		string word
	) : this
	(
		nullables,
		new ScalarOfValue<string>(word)
	)
	{
	}
	
	public WordsWhenNulls
	(
		IEnumerable<string?> nullables,
		IScalar<string> word
	) : base
	(
		new SelectedByExpression<string?, string>(
			nullables,
			nullable => new WordWhenNull(nullable, word).Value)
	)
	{
	}
}