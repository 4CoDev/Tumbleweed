using Tumbleweed.Scalar.Function;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;

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
		new System<IDictionary<TKey, TValue>>(function)
	)
	{
	}
	
	public DictionaryOfFunction
	(Subroutine.Function.Nullary.Any<IDictionary<TKey, TValue>> function
	) : base
	(
		new DictionaryOfScalar<TKey, TValue>(
			new Tumbleweed.Scalar.Function.Result<IDictionary<TKey, TValue>>(function))
	)
	{
	}
}