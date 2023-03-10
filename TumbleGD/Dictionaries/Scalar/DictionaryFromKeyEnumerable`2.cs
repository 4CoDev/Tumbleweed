using Tumbleweed.Scalars;

namespace TumbleGD.Dictionaries.Scalar;

public sealed class DictionaryFromEnumerable<TKey, TValue> :
	IScalar<IDictionary<TKey, TValue>>
	where TKey : notnull
{
	public DictionaryFromEnumerable
	(
		IEnumerable<TKey> enumerable,
		TValue defaultValue
	) 
	{
		this.enumerable = enumerable;
		this.defaultValue = defaultValue;
	}

	public IDictionary<TKey, TValue> Value
	{
		get
		{
			IDictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
			foreach (TKey key in enumerable)
			{
				dictionary.Add(key, defaultValue);
			}
			return dictionary;
		}
	}

	private readonly IEnumerable<TKey> enumerable;
	
	private readonly TValue defaultValue;
}