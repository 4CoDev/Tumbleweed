using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.Specific.Action.Filler.Property.Value;

public sealed class One<T> : Procedure::Envelope
{
	public One
	(
		T[,,] array,
		Property::Any<T> filler
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
		Property::Any<T> filler
	) : base
	(
		new Procedure::From.System(
			() => Procedure(array, filler))
	)
	{
	}

	private static void Procedure
	(
		Property::Any<T[,,]> array,
		Property::Any<T> filler
	)
	{
		Procedure(array.Value, filler);
	}
	
	private static void Procedure
	(
		T[,,] array,
		Property::Any<T> filler
	)
	{
		for (Int32 x = 0; x < array.GetLength(0); x++)
		for (Int32 y = 0; y < array.GetLength(1); y++)
		for (Int32 z = 0; z < array.GetLength(2); z++)
			array[x, y, z] = filler.Value;
	}
}