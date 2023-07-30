using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.String.From.System.NonNullable;

namespace Tumbleweed.String;

public sealed class Conсatenated : Envelope
{
	public Conсatenated(params System.String[] strings) : this
	(
		new Multiple(strings)
	)
	{
	}
	
	public Conсatenated(params Any[] strings) : this
	(
		new Concatenated<Any>(strings)
	)
	{
	}
	
	public Conсatenated(IEnumerable<Any> strings) : base
	(
		new One(
			new Actual<System.String>(
				() => System.String.Concat(strings)))
	)
	{
	}
}