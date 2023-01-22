using Tumbleweed.Scalars;

namespace Tumbleweed.WithGodot.Dictionaries;

public sealed class DictionaryFromKeyEnumerable<TKey, TValue> :
	DictionaryEnvelope<TKey, TValue>
	where TKey : notnull
{
	public DictionaryFromKeyEnumerable
	(
		IEnumerable<TKey> enumerable,
		TValue defaultValue
	) : this
	(
		new Scalar.DictionaryFromEnumerable<TKey, TValue>(enumerable, defaultValue)
	)
	{
	}
	
	private DictionaryFromKeyEnumerable
	(
		IScalar<IDictionary<TKey, TValue>> scalar
	) : base
	(
		new DictionaryFromScalar<TKey, TValue>(scalar)
	)
	{
	}
}