using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class WordsWhenNulls : EnumerableEnvelope<string>
{
	public WordsWhenNulls
	(
		IEnumerable<object?> nullables,
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
		IEnumerable<object?> nullables,
		IScalar<string> word
	) : base
	(
		new SelectedByExpression<object?, string>(
			nullables,
			nullable => new WordWhenNull(nullable, word).Value)
	)
	{
	}
}