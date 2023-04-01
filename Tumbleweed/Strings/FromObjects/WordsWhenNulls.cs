using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class WordsWhenNulls : EnumerableEnvelope<String>
{
	public WordsWhenNulls
	(
		IEnumerable<Object?> nullables,
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
		IEnumerable<Object?> nullables,
		IScalar<String> word
	) : base
	(
		new SelectedByExpression<Object?, String>(
			nullables,
			nullable => new WordWhenNull(nullable, word).Value)
	)
	{
	}
}