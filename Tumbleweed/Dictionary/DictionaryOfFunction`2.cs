using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;

namespace Tumbleweed.Dictionary;

public sealed class DictionaryOfFunction<TKey, TValue> :
	DictionaryEnvelope<TKey, TValue> 
	where TKey : notnull
{
	public DictionaryOfFunction
	(
		Func<IDictionary<TKey, TValue>> function
	) : this
	(
		new FunctionFromSystem<IDictionary<TKey, TValue>>(function)
	)
	{
	}
	
	public DictionaryOfFunction
	(
		IFunction<IDictionary<TKey, TValue>> function
	) : base
	(
		new DictionaryOfScalar<TKey, TValue>(
			new ResultOfFunction<IDictionary<TKey, TValue>>(function))
	)
	{
	}
}