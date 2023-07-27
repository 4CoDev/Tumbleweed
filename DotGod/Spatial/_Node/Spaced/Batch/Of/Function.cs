using Tumbleweed.Scalar.Function;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;

namespace DotGod.Spatial._Node.Spaced.Batch.Of;

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
			new Tumbleweed.Scalar.Function.Result<Abstract.IBatch>(function))
	)
	{
	}
}