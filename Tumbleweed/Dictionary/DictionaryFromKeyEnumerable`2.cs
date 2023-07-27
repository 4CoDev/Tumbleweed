using Tumbleweed.Scalar;

namespace Tumbleweed.Dictionary;

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
		Any<IDictionary<TKey, TValue>> any
	) : base
	(
		new DictionaryOfScalar<TKey, TValue>(any)
	)
	{
	}
}