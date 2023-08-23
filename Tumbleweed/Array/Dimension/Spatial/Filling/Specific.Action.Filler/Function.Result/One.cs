using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Array.Dimension.Spatial.Filling.Specific.Action.Filler.Function.Result;

public sealed class One<T> : Procedure::Envelope
{
	public One
	(
		T[,,] array,
		Function::Any<T> filler
	) : this
	(
		new Scalar::With.Value<T[,,]>(array),
		filler
	)
	{
	}
	
	public One
	(
		Scalar::Any<T[,,]> array,
		Function::Any<T> filler
	) : base
	(
		new System.Filling.Specific.Action.Filler.Scalar.Value.One<T>(
			array,
			new Scalar::Function.Result.Actual<T>(filler))
	)
	{
	}
}