using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary.From;

namespace DotGod.Node.Spatial.Spaced.Batch.Of;

public sealed class Function : Envelope
{
	public Function(Func<Abstract.IBatch> function) : this
	(
		new System<Abstract.IBatch>(function)
	)
	{
	}
	
	public Function(Tumbleweed.Subroutine.Function.Nullary.Any<Abstract.IBatch> function) : base
	(
		new Scalar(
			new Actual<Abstract.IBatch>(function))
	)
	{
	}
}