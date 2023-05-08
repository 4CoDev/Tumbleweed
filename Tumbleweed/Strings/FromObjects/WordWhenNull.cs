using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class WordWhenNull : ScalarEnvelope<String>
{
	public WordWhenNull(Object? origin, String word) : this
	(
		new ScalarValue<Object?>(origin),
		new ScalarValue<String>(word)
	)
	{
	}
	
	public WordWhenNull(IScalar<Object?> origin, String word) : this
	(
		origin,
		new ScalarValue<String>(word)
	)
	{
	}
	
	public WordWhenNull(Object? origin, IScalar<String> word) : this
	(
		new ScalarValue<Object?>(origin),
		word
	)
	{
	}
	
	public WordWhenNull
	(
		IScalar<Object?> origin,
		IScalar<String> word
	) : base
	(
		new ResultOfFunction<String>(
			() => new NullableFromNullable(origin.Value).Value ?? word.Value)
	)
	{
	}
}