using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class WordWhenNull : ScalarEnvelope<String>
{
	public WordWhenNull(Object? origin, String word) : this
	(
		new ScalarOfValue<Object?>(origin),
		new ScalarOfValue<String>(word)
	)
	{
	}
	
	public WordWhenNull(IScalar<Object?> origin, String word) : this
	(
		origin,
		new ScalarOfValue<String>(word)
	)
	{
	}
	
	public WordWhenNull(Object? origin, IScalar<String> word) : this
	(
		new ScalarOfValue<Object?>(origin),
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
		new ValueOfFunction<String>(
			() => new NullableFromNullable(origin.Value).Value ?? word.Value)
	)
	{
	}
}