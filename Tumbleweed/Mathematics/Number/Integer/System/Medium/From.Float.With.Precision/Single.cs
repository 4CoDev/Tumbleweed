using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.With;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Float.With.Precision;

public sealed class Single : Envelope<Int32>
{
	public Single(global::System.Single single) : this
	(
		new Value<global::System.Single>(single)
	)
	{
	}
	
	public Single(Any<global::System.Single> single) : base
	(
		new Actual<Int32>(
			() => (Int32) single.Value)
	)
	{
	}
}