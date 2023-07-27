using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.System.Medium.From.Float.With.Precision;

public sealed class Single : TW.Scalar.Envelope<Int32>
{
	public Single(global::System.Single single) : this
	(
		new TW.Scalar.Of.Value<global::System.Single>(single)
	)
	{
	}
	
	public Single(TW.Scalar.Any<global::System.Single> single) : base
	(
		new TW.Scalar.Function.Result<Int32>(
			() => (Int32) single.Value)
	)
	{
	}
}