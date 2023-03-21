using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Dictionaries;

public sealed class DictionaryOfFunction<TKey, TValue> :
	DictionaryEnvelope<TKey, TValue> 
	where TKey : notnull
{
	public DictionaryOfFunction
	(
		Func<IDictionary<TKey, TValue>> function
	) : this
	(
		new NullaryFromSystem<IDictionary<TKey, TValue>>(function)
	)
	{
	}
	
	public DictionaryOfFunction
	(
		INullaryFunction<IDictionary<TKey, TValue>> function
	) : base
	(
		new DictionaryOfScalar<TKey, TValue>(
			new ValueOfFunction<IDictionary<TKey, TValue>>(function))
	)
	{
	}
}