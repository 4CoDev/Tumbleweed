using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.Specific.Action.Filler.Function.Result;

public sealed class One<T> : Procedure::Envelope
{
	public One
	(
		T[,,] array,
		Function::Any<T> filler
	) : this
	(
		new Property::With.Value.One<T[,,]>(array),
		filler
	)
	{
	}
	
	public One
	(
		Property::Any<T[,,]> array,
		Function::Any<T> filler
	) : base
	(
		new Property.Value.One<T>(
			array,
			new Property::Function.Result.Actual<T>(filler))
	)
	{
	}
}